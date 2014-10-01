using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace HP.Presentacion
{
    public partial class frmListadoFaltantes : Form
    {
        #region Constructor

        public frmListadoFaltantes()
        {
            InitializeComponent();
            this.dgvListadoFaltantes.Columns["colCantidadAPedir"].ValueType = typeof(UInt16);
            ProveedorRellenarCombobox();
            lblFecha.Text = DateTime.Today.ToShortDateString();
        }
        
        #endregion

        #region Eventos

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvListadoFaltantes.Rows.Clear();
            CargarGrilla(((Entidades.Proveedor)cbxProveedor.SelectedItem).Id_prov);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarLibroAlListado();
        }

        private void dgvListadoFaltantes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("El dato ingresado en \'Cantidad a Pedir\' tiene un formato " +
                "incorrecto o incompatible.\nDebe ingresar un número entero positivo",
                "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            RealizarPedido();
        }

        private void dgvListadoFaltantes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //Columna correspondiente a "colCantidadAPedir"
            {
                if (dgvListadoFaltantes.Rows[e.RowIndex].Cells["colCantidadAPedir"].Value == DBNull.Value)
                {
                    dgvListadoFaltantes.Rows[e.RowIndex].Cells["colCantidadAPedir"].Value = 0;
                }
                ReCalcularSubtotal(e.RowIndex);
                if (Convert.ToInt32(dgvListadoFaltantes.Rows[e.RowIndex].Cells["colCantidadAPedir"].Value) > 0)
                { dgvListadoFaltantes.Rows[e.RowIndex].Cells["colPedir"].Value = true; }
                else
                { dgvListadoFaltantes.Rows[e.RowIndex].Cells["colPedir"].Value = false; }
            }
            else if (e.ColumnIndex == 0) //Columna correspondiente a "colPedir"
            {
                if (Convert.ToBoolean(dgvListadoFaltantes.Rows[e.RowIndex].Cells["colPedir"].Value))
                { ReCalcularSubtotal(e.RowIndex); }
                else
                { dgvListadoFaltantes.Rows[e.RowIndex].Cells["colSubtotal"].Value = 0; }
            }
            CalcularTotal();
        }

        #endregion

        #region Métodos

        private void ProveedorRellenarCombobox()
        {
            Negocio.Proveedores nProveedores = new HP.Negocio.Proveedores();
            cbxProveedor.DataSource = nProveedores.ObtenerHabilitados();
        }

        private void CargarGrilla(int id_prov)
        {
            int cantAPedir;
            bool pedir = false;

            Negocio.Libros nLibro = new HP.Negocio.Libros();
            Entidades.Libros pLibros = nLibro.ObtenerListadoFaltantes(id_prov);
            
            //El foreach anidado se debe a que pueden haber dos compras pendientes distintas en las cuales
            //se haya pedido el mismo libro. Para evitar que aparezca dos veces en el listado se suman sus
            //cant_pedidas y se lo muestra una unica vez.
            foreach (Entidades.Libro pLibro in pLibros)
            {
                float subtotal = 0;
                bool agregar = true;

                foreach (DataGridViewRow row in dgvListadoFaltantes.Rows)
                {
                    if (pLibro.Id_libro == Convert.ToInt32(row.Cells["colIdLibro"].Value))
                    {
                        agregar = false;

                        row.Cells["colCantPedidaNoEntregada"].Value = (pLibro.Cant_pedida +
                                                Convert.ToInt32(row.Cells["colCantPedidaNoEntregada"].Value));
                        
                        cantAPedir = (pLibro.Stock_deseable - (pLibro.Stock_actual +
                                                Convert.ToInt32(row.Cells["colCantPedidaNoEntregada"].Value)));
                        if (cantAPedir <= 0)
                        {
                            row.Cells["colCantidadAPedir"].Value = 0;
                            row.Cells["colPedir"].Value = false;
                        }
                        if (cantAPedir > 0)
                        {
                            row.Cells["colCantidadAPedir"].Value = cantAPedir;
                            row.Cells["colPedir"].Value = true;
                            row.Cells["colSubtotal"].Value = (cantAPedir * pLibro.Colec.PrecioCompra);
                        }
                    }
                }

                if (agregar)
                {
                    cantAPedir = (pLibro.Stock_deseable - (pLibro.Stock_actual + pLibro.Cant_pedida));
                    if (cantAPedir <= 0)
                    { cantAPedir = 0; }
                    else
                    { 
                        pedir = true;
                        subtotal = cantAPedir * pLibro.Colec.PrecioCompra;
                    }
                    this.dgvListadoFaltantes.Rows.Add(pedir, pLibro.Id_libro, pLibro.Isbn,
                                        pLibro.Titulo_libro, pLibro.Stock_actual, pLibro.Stock_minimo,
                                        pLibro.Stock_deseable, cantAPedir, pLibro.Cant_pedida,
                                        pLibro.Colec.PrecioCompra, subtotal);

                }
            }
            dgvListadoFaltantes.Sort(dgvListadoFaltantes.Columns["colTituloLibro"], ListSortDirection.Ascending);
            CalcularTotal();                
        }

        private void AgregarLibroAlListado()
        {
            int id_proveedor = ((Entidades.Proveedor)cbxProveedor.SelectedItem).Id_prov;
            frmAgregarAlListadoFaltantes formAgregar = new frmAgregarAlListadoFaltantes(id_proveedor);

            do
            {
                formAgregar.ShowDialog();
                if (formAgregar.LibrosAAgregar != null)
                {
                    Font fuente = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
                    int indiceUltimaFila = this.dgvListadoFaltantes.Rows.Count - 1;

                    //Verifica que no este todavia en el listado.
                    foreach (Entidades.Libro libro in formAgregar.LibrosAAgregar)
                    {
                        bool yaExiste = false;
                        foreach (DataGridViewRow row in dgvListadoFaltantes.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["colIdLibro"].Value) == libro.Id_libro)
                            {
                                yaExiste = true;
                                break;
                            }
                        }
                        if (!yaExiste)
                        {
                            int cantAPedir = (libro.Stock_deseable - (libro.Stock_actual + libro.Cant_pedida));
                            if (cantAPedir < 0)
                            { cantAPedir = 0; }
                            float subtotal = cantAPedir * libro.Colec.PrecioCompra;

                            this.dgvListadoFaltantes.Rows.Add(true, libro.Id_libro, libro.Isbn,
                                                libro.Titulo_libro, libro.Stock_actual, libro.Stock_minimo,
                                                libro.Stock_deseable, cantAPedir, libro.Cant_pedida,
                                                libro.Colec.PrecioCompra, subtotal);
                            indiceUltimaFila++;
                            this.dgvListadoFaltantes.Rows[indiceUltimaFila].Cells["colCantidadAPedir"].Style.Font = fuente;
                            this.dgvListadoFaltantes.Rows[indiceUltimaFila].Cells["colCantidadAPedir"].Style.ForeColor = Color.LimeGreen;
                        }

                    }
                }
            }
            while (formAgregar.DialogResult == DialogResult.Retry);
            CalcularTotal();
        }

        private void RealizarPedido()
        {
            int id_compra = -1;

            //Si hay por lo menos una casilla "pedir" checkeada, se crea una nueva compra
            foreach (DataGridViewRow fila in dgvListadoFaltantes.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["colPedir"].Value))
                {
                    Negocio.Compras nCompra = new HP.Negocio.Compras();
                    id_compra = nCompra.Agregar(((Entidades.Proveedor)cbxProveedor.SelectedItem).Id_prov);
                    break;
                }
            }

            if (id_compra != -1)
            {
                Entidades.Lineas_Pedido lineas = new HP.Entidades.Lineas_Pedido();
                foreach (DataGridViewRow row in dgvListadoFaltantes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colPedir"].Value))
                    {
                        Entidades.Linea_Pedido linea = new HP.Entidades.Linea_Pedido();
                        Entidades.Libro libro = new HP.Entidades.Libro();

                        linea.Id_compra = id_compra;
                        libro.Id_libro = Convert.ToInt32(row.Cells["colIdLibro"].Value);
                        linea.Libro = libro;
                        linea.Cant_pedida = Convert.ToInt32(row.Cells["colCantidadAPedir"].Value);

                        Negocio.Lineas_Pedido nLinea = new HP.Negocio.Lineas_Pedido();
                        nLinea.Agregar(linea);
                    }
                }
                MessageBox.Show("El pedido ha sido registrado con éxito", "Pedido Registrado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Para realizar un pedido debe activar la casilla " + 
                    "\"Pedir\" de al menos un libro.", "No hay libros marcados para pedir",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*public bool ValidarCantidadesAPedir()
        {/////////////////No va porque cuando termino de editar la celda valido que el valor no sea DBNull
            foreach (DataGridViewRow row in dgvListadoFaltantes.Rows)
            {
                if (row.Cells["colCantidadAPedir"].Value == DBNull.Value &&
                    Convert.ToBoolean(row.Cells["colPedir"].Value))
                {
                    MessageBox.Show("No todos los libros seleccionados para ser pedidos " +
                        "tienen completa su casilla \"Cantidad a Pedir\"",
                        "Faltan Valores en Cantidad a Pedir", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }
            return true;
        }
         */

        public void ReCalcularSubtotal(int filaSeleccionada)
        {
            dgvListadoFaltantes.Rows[filaSeleccionada].Cells["colSubtotal"].Value =
                 float.Parse(dgvListadoFaltantes.Rows[filaSeleccionada].Cells["colCantidadAPedir"].Value.ToString()) *
                 float.Parse(dgvListadoFaltantes.Rows[filaSeleccionada].Cells["colPrecioCompra"].Value.ToString());
        }

        public void CalcularTotal()
        {
            float total = 0;

            foreach (DataGridViewRow row in dgvListadoFaltantes.Rows)
            {
                total = total + float.Parse(row.Cells["colSubtotal"].Value.ToString());
            }
            tbxTotal.Text = "$" + total.ToString();
        }

        #endregion
        
    }
}