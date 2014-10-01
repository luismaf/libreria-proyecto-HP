using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HP.Presentacion
{
    public partial class frmDetallePedido : Form
    {
        //Ver comentario en la ultima linea del metodo GuardarPedido

        #region Variables Globales

        Entidades.Compra compra = new HP.Entidades.Compra();
        Entidades.Colecciones colecciones = new HP.Entidades.Colecciones();
        float? montoNC = 0;
        float precioGuardado;
        int cantAceptadaGuardada;
        
        #endregion

        #region Constructor

        public frmDetallePedido(int id_compra)
        {
            InitializeComponent();
            dgvListadoLibros.Columns["colCantAceptada"].ValueType = typeof(int); 
            dgvListadoLibros.Columns["colPrecioCompra"].ValueType = typeof(float);
            CargarDetalles(id_compra);
            ActualizarFechaPresentacionCheque();
        }

        #endregion

        #region Eventos

        private void dgvListadoLibros_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Cuando se edita el precio de compra de un libro, se guarda el valor que tenia por si luego
            //se ingresa un valor no valido, ya sea negativo o vacio. De esta manera se restaura el valor anterior
            if (e.ColumnIndex == 5) //Columna Precio de Compra
            { precioGuardado = float.Parse(dgvListadoLibros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()); }
            else if (e.ColumnIndex == 4)
            { cantAceptadaGuardada = Convert.ToInt32(dgvListadoLibros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value); }
        }

        private void dgvListadoLibros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ValidarCeldasEditables(e.ColumnIndex, e.RowIndex);
            
            if (e.ColumnIndex == 5)//Columna PrecioCompra
            { ActualizarPreciosColeccion(e.RowIndex); }
            RecalcularSubtotales();
        }

        private void dgvListadoLibros_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string mensaje = "";
            if (e.ColumnIndex == 4) //Corresponde a la columna "colCantidadAceptada"
            {
                mensaje += "El valor ingresado en \'Cantidad Aceptada\' tiene un formato " +
                "incorrecto o incompatible.\nDebe ingresar un número entero positivo";
            }
            else if (e.ColumnIndex == 5) //Corresponde a la columna "colPrecioCompra"
            {
                mensaje += "El valor ingresado en \'Precio de Compra\' tiene un formato " +
                "incorrecto o incompatible.\nDebe ingresar un número entero o con decimales";
            }
            MessageBox.Show(mensaje, "Error en el ingreso de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAgregarNC_Click(object sender, EventArgs e)
        {
            AgregarNotaCredito();
        }

        private void btnEliminarNC_Click(object sender, EventArgs e)
        {
            EliminarNotaCredito();
        }

        private void dgvNotasCredito_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvNotasCredito.Rows.Count == 0)
            { btnEliminarNC.Enabled = false; }

            ActualizarMontoNC();
        }

        private void btnGuardarComoPedidoEntregado_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEditables())
            { GuardarPedido(); }
        }

        private void rbt30Dias_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarFechaPresentacionCheque();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Metodos

        public void CargarDetalles(int id_compra)
        {
            Negocio.Compras nCompras = new HP.Negocio.Compras();
            compra = nCompras.VerDetalles(id_compra);

            lblNroPedido.Text = compra.Id_Compra.ToString();
            lblProveedor.Text = compra.Prov.Razon_social;
            lblEstado.Text = compra.Desc_Estado_Compra;
            lblFechaPedido.Text = compra.Fecha_Pedido.ToShortDateString();

            if (compra.Desc_Estado_Compra.Equals("Entregado"))
            {
                lblTituloFechaEntregado.Visible = true;
                lblFechaEntregado.Visible = true;
                lblFechaEntregado.Text = compra.Fecha_Entregado.Value.ToShortDateString();
                DeshabilitarControles();
                
            }
            if (compra.Desc_Estado_Compra.Equals("Cancelado"))
            {
                lblTituloFechaCancelado.Visible = true;
                lblFechaCancelado.Text = compra.Fecha_Cancelado.Value.ToShortDateString();
                lblFechaCancelado.Visible = true;
                DeshabilitarControles();
            }

            //Carga el DataGridView con las lineas de pedido
            Negocio.Lineas_Pedido nLineas_Pedido = new HP.Negocio.Lineas_Pedido();
            if (compra.Desc_Estado_Compra == "Pendiente" || compra.Desc_Estado_Compra == "Cancelado")
            {
                compra.Lineas_pedido = nLineas_Pedido.ObtenerTodasNoEntregadas(compra.Id_Compra);
                foreach (Entidades.Linea_Pedido linea in compra.Lineas_pedido)
                {
                    dgvListadoLibros.Rows.Add(linea.Libro.Id_libro, linea.Libro.Isbn, linea.Libro.Titulo_libro,
                                              linea.Cant_pedida, linea.Cant_pedida,   linea.Libro.Colec.PrecioCompra,
                                              linea.Libro.Colec.PrecioCompra * linea.Cant_pedida,
                                              linea.Libro.Colec.Id_colec, linea.Libro.Colec.Cod_colec,
                                              linea.Libro.Colec.Titulo_colec, linea.Id_Linea_Pedido);
                }
            }
/*
             * El siguiente codigo corresponde a aquellos pedidos entregados, que difiere del codigo de los
             * pedidos pendientes o cancelados porque en este caso hay que obtener de la base de datos
             * el monto del cheque, la fecha de vencimiento del cheque y las notas de credito utilizadas
            else if (compra.Desc_Estado_Compra == "Entregado")
            {
                compra.Lineas_pedido = nLineas_Pedido.ObtenerTodasEntregadas(compra.Id_Compra);
                foreach (Entidades.Linea_Pedido linea in compra.Lineas_pedido)
                {
                    dgvListadoLibros.Rows.Add(linea.Libro.Id_libro, linea.Libro.Isbn, linea.Libro.Titulo_libro,
                                              linea.Cant_pedida, linea.Cant_aceptada,
                                              linea.Libro.Colec.PrecioCompra,
                                              linea.Libro.Colec.PrecioCompra * linea.Cant_aceptada,
                                              linea.Libro.Colec.Id_colec);
                }
                tbxFechaPresentacionCheque.Text = compra.Fecha_Venc_Cheque.ToString();
            }
*/

            ActualizarMontoCompra();
        }

        public void ActualizarPreciosColeccion(int indiceFila)
        {
            //Si se modifico algun precio de compra se guarda el nuevo precio y el id de la coleccion.
            //Se agregan a una lista de colecciones y cuando guarda el pedido como entregado se
            //actualizan los precios.

            Entidades.Coleccion coleccion = new HP.Entidades.Coleccion();

            coleccion.Id_colec = Convert.ToInt32(dgvListadoLibros.Rows[indiceFila].Cells["colIdColec"].Value);
            coleccion.Cod_colec = dgvListadoLibros.Rows[indiceFila].Cells["colCod_Colec"].Value.ToString();
            coleccion.Titulo_colec = dgvListadoLibros.Rows[indiceFila].Cells["colTitulo_Colec"].Value.ToString();
            coleccion.PrecioCompra = float.Parse(dgvListadoLibros.Rows[indiceFila].Cells["colPrecioCompra"].Value.ToString());

            //Si ya se encuentra la coleccion en la lista es porq fue modificada antes, pero solo me interesa la
            //ultima modificacion, por lo que borro la anterior y agrego la nueva
            foreach (Entidades.Coleccion colec in colecciones)
            {
                if (colec.Id_colec == coleccion.Id_colec)
                {
                    colecciones.Remove(colec);
                    break;
                }
            }
            colecciones.Add(coleccion);

            //Actualiza en la grilla los precios de los demas libros pertenecientes a la misma coleccion
            foreach (DataGridViewRow row in dgvListadoLibros.Rows)
            {
                if (Convert.ToInt32(row.Cells["colIdColec"].Value) == coleccion.Id_colec)
                {
                    row.Cells["colPrecioCompra"].Value = coleccion.PrecioCompra;
                }
            }
        }

        public void ActualizarMontoCompra()
        {
            compra.Monto_Compra = 0;
            foreach (DataGridViewRow row in dgvListadoLibros.Rows)
            {
                compra.Monto_Compra += float.Parse(Convert.ToString(row.Cells["colSubtotal"].Value));
            }
            tbxMontoCompra.Text = compra.Monto_Compra.ToString();
            RecalcularNotasCredito();
        }

        public void ActualizarMontoCheque()
        {
            compra.Monto_Cheque = compra.Monto_Compra - montoNC;
            if ((compra.Monto_Cheque) > 0)
            {
                tbxMontoCheque.Text = Convert.ToString(compra.Monto_Cheque);
                tbxNroCheque.ReadOnly = false;
                tbxBanco.ReadOnly = false;
                gbxFechaPresentacionCheque.Enabled = true;
            }
            else
            { 
                tbxMontoCheque.Text = "0";
                tbxNroCheque.ReadOnly = true;
                tbxBanco.ReadOnly = true;
                gbxFechaPresentacionCheque.Enabled = false;
            }
        }

        public void ActualizarMontoNC()
        {
            montoNC = 0;
            foreach (DataGridViewRow row in dgvNotasCredito.Rows)
            { montoNC += float.Parse(Convert.ToString(row.Cells["colMontoAUtilizar"].Value)); }
            tbxTotalNC.Text = "$" + montoNC.ToString();
            ActualizarMontoCheque();
        }

        public void AgregarNotaCredito()
        {
            frmAgregarNC formAgregarNC = new frmAgregarNC((compra.Monto_Compra - montoNC), compra.Prov.Id_prov, compra.Prov.Razon_social);
            formAgregarNC.ShowDialog();

            if (formAgregarNC.Notas_Agregadas != null)
            {
                string mensaje = "";
                foreach (Entidades.Nota_Credito nota in formAgregarNC.Notas_Agregadas)
                {
                    //Evito agregar una NC que ya habia cargado
                    bool yaAgregada = false;
                    foreach (DataGridViewRow row in dgvNotasCredito.Rows)
                    {
                        if (nota.Id_Nota_Credito == Convert.ToInt32(row.Cells["colIdNc"].Value))
                        {
                            yaAgregada = true;
                            mensaje = "Alguna de las notas de crédito que intento agregar ya habian sido " + 
                                      "cargadas, por lo que no se han vuelto a agregar.\n" +
                                      "Si desea utilizar un mayor monto de la misma, eliminela junto con " +
                                      "otra/s nota/s y vuelva a cargarla.";
                            break;
                        }
                    }
                    if (!yaAgregada)
                    { dgvNotasCredito.Rows.Add(nota.Id_Nota_Credito, nota.Codigo_Nc, nota.Saldo_Restante); }
                }

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, "Nota de Crédito Ya Cargada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RecalcularNotasCredito();
            }
        }

        public void EliminarNotaCredito()
        {
            foreach (DataGridViewRow dgvFila in dgvNotasCredito.SelectedRows)
            { dgvNotasCredito.Rows.Remove(dgvFila); }
            
            if (dgvNotasCredito.Rows.Count == 0)
            { btnEliminarNC.Enabled = false; }

            ActualizarMontoNC();
        }

        public void RecalcularSubtotales()
        {
            foreach (DataGridViewRow row in dgvListadoLibros.Rows)
            {
                row.Cells["colSubtotal"].Value = (Convert.ToInt32(row.Cells["colCantAceptada"].Value) *
                                                float.Parse(row.Cells["colPrecioCompra"].Value.ToString()));
            }
            ActualizarMontoCompra();
        }

        public void RecalcularNotasCredito()
        {   //En caso de que haya agregado NCs y luego cambie un precio de compra. Tengo que revisar las NC
            //a utilizar porque podrian superar el nuevo monto de compra
            
            float? montoCompra = compra.Monto_Compra;
            montoNC = 0;
            foreach (DataGridViewRow row in dgvNotasCredito.Rows)
            {
                float? montoAUtilizar = float.Parse(row.Cells["colMontoAUtilizar"].Value.ToString());
                if (montoCompra >= montoAUtilizar)
                {
                    montoCompra -= montoAUtilizar;
                    montoNC += montoAUtilizar;
                }
                else
                {
                    montoAUtilizar = montoCompra;
                    montoCompra = 0;
                    montoNC += montoAUtilizar;
                    row.Cells["colMontoAUtilizar"].Value = montoAUtilizar;
                }
            }

            //Elimino aquellas filas que quedaron con "Monto a Utilizar" = 0
            for (int i = (dgvNotasCredito.Rows.Count - 1); i >= 0; i--)
            {
                if (float.Parse(dgvNotasCredito.Rows[i].Cells["colMontoAUtilizar"].Value.ToString()) == 0)
                { dgvNotasCredito.Rows.RemoveAt(i); }
            }

            if (dgvNotasCredito.Rows.Count > 0)
            { btnEliminarNC.Enabled = true; }

            tbxTotalNC.Text = "$" + montoNC.ToString();
            ActualizarMontoCheque();
        }
        
        public void ValidarCeldasEditables(int indiceCol, int indiceRow)
        {
            switch (indiceCol)
            {
                case 4: //Columna Cantidad Aceptada
                    if (dgvListadoLibros.Rows[indiceRow].Cells["colCantAceptada"].Value == DBNull.Value)
                    { dgvListadoLibros.Rows[indiceRow].Cells["colCantAceptada"].Value = 0; }
                    else if (Convert.ToInt32(dgvListadoLibros.Rows[indiceRow].Cells["colCantAceptada"].Value) < 0)
                    { dgvListadoLibros.Rows[indiceRow].Cells["colCantAceptada"].Value = cantAceptadaGuardada; }
                    break;
                case 5: //Columna PrecioCompra
                    if (dgvListadoLibros.Rows[indiceRow].Cells["colPrecioCompra"].Value == DBNull.Value ||
                        float.Parse(dgvListadoLibros.Rows[indiceRow].Cells["colPrecioCompra"].Value.ToString()) < 0)
                    {
                        dgvListadoLibros.Rows[indiceRow].Cells["colPrecioCompra"].Value = precioGuardado;
                    }
                    break;
                default:
                    break;
            }
            
        }
        
        public void GuardarPedido()
        {
            //Actualizo las cantidades aceptadas de cada linea de pedido en el objeto compra, ya que
            //este objeto tiene las cantidades aceptadas por defecto, que son iguales a las cant pedidas.
            foreach (DataGridViewRow row in dgvListadoLibros.Rows)
            {
                foreach (Entidades.Linea_Pedido linea in compra.Lineas_pedido)
                {
                    if (Convert.ToInt32(row.Cells["colIdLineaPedido"].Value) == linea.Id_Linea_Pedido)
                    {
                        linea.Cant_aceptada = Convert.ToInt32(row.Cells["colCantAceptada"].Value);
                        break;
                    }
                }
            }

            //Al Objeto compra le agrego las notas de credito a utilizar
            Entidades.Notas_Credito notas = new HP.Entidades.Notas_Credito();
            foreach (DataGridViewRow row in dgvNotasCredito.Rows)
            {
                Entidades.Nota_Credito nota = new HP.Entidades.Nota_Credito();

                nota.Id_Nota_Credito = Convert.ToInt32(row.Cells["colIdNc"].Value);
                nota.Codigo_Nc = Convert.ToInt32(row.Cells["colCodNC"].Value);
                nota.Monto_Aplicado = float.Parse(row.Cells["colMontoAUtilizar"].Value.ToString());

                notas.Add(nota);
            }
            compra.Notas_Credito = notas;

            //Si el montoCheque es distinto de cero entonces tengo guardar los datos correspondientes al cheque
            if (compra.Monto_Cheque != 0)
            {
                compra.Nro_Cheque = Convert.ToInt64(tbxNroCheque.Text.Trim());
                compra.Banco = tbxBanco.Text.Trim();
                compra.Fecha_Venc_Cheque = Convert.ToDateTime(tbxFechaPresentacionCheque.Text.Trim());
            }
            else
            { 
                compra.Monto_Cheque = null;
                compra.Nro_Cheque = null;
                compra.Banco = "";
                compra.Fecha_Venc_Cheque = null;
            }

            //Modifico la Base de datos
            string error = "";

            Negocio.Compras nCompra = new HP.Negocio.Compras();
            error = nCompra.GuardarComoEntregada(compra);

            //Si no hya errores continúo
            if (error.Equals(""))
            {
                //Actualizar los precioCompra de las colecciones contenidas dentro de "colecciones"
                //(Ver ActualizarPreciosColeccion)
                Negocio.Colecciones nColecccion = new HP.Negocio.Colecciones();
                foreach (Entidades.Coleccion coleccion in colecciones)
                { 
                    error = nColecccion.ActualizarPrecioCompra(coleccion.Id_colec, coleccion.PrecioCompra);
                    if (!error.Equals(""))
                    { break; }
                }

                //Al cambiar los precios de compra, ofrece actualizar los precios de venta
                if (colecciones.Count != 0 && MessageBox.Show("Los precios de compra de una o más colecciones han cambiado.\n" +
                                                              "Desea actualizar los precios de venta correspondientes?",
                                                              "Precios de Compra Modificados", MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question) == DialogResult.Yes)
                { new frmActualizarPreciosVenta(colecciones).ShowDialog(); }
            }

            if (!error.Equals(""))
            { MessageBox.Show(error, "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                //Devuelvo Yes al form anterior para que quite esta compra del listado de las pendientes
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        public void DeshabilitarControles()
        {
            dgvListadoLibros.Enabled = false;
            btnAgregarNC.Enabled = false;
            btnEliminarNC.Enabled = false;
            btnGuardarComoPedidoEntregado.Enabled = false;
            tbxNroCheque.ReadOnly = true;
            tbxBanco.ReadOnly = true;
            gbxDatosDelPago.Enabled = false;
            dgvNotasCredito.Enabled = false;
        }

        public void ActualizarFechaPresentacionCheque()
        {
            int dias = rbt30Dias.Checked ? 30 : 60;
            tbxFechaPresentacionCheque.Text = DateTime.Today.AddDays(dias).ToShortDateString();
        }

        public bool ValidarCamposEditables()
        {
            if (compra.Monto_Cheque != 0 && (tbxBanco.Text.Trim().Equals("") ||
                         !Regex.IsMatch(tbxNroCheque.Text.Trim(), @"^\d{8}$")))
            {
                MessageBox.Show("Debe ingresar el nombre del banco al cual corresponde " +
                           "el cheque y el número del mismo en el formato correcto." +
                           "\nEl número del cheque debera ser de 8 dígitos",
                           "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion
        
    }
}