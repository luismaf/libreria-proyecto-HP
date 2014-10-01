using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HP.Presentacion
{
    public partial class frmActualizarPreciosVenta : Form
    {

        #region Constructor

        public frmActualizarPreciosVenta(Entidades.Colecciones colecciones)
        {
            InitializeComponent();
            dgvListadoColecciones.Columns["colPrecioVentaNuevo"].ValueType = typeof(float);
            CargarGrilla(colecciones);
        }

        #endregion

        #region Eventos

        private void dgvListadoColecciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ValidarCeldasEditables(e.ColumnIndex, e.RowIndex);
        }

        private void dgvListadoColecciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string mensaje = "";
            if (e.ColumnIndex == 5) //Corresponde a la columna "colCantidadAceptada"
            {
                mensaje += "El valor ingresado en \'Precio de Venta Nuevo\' tiene un formato " +
                "incorrecto o incompatible.\nDebe ingresar un número entero o decimal positivo";
            }
            MessageBox.Show(mensaje, "Error en el ingreso de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPrecios();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todavia no registro los nuevos precios de venta.\nDesea cerrar el formulario " +
                                "igualmente, sin guardar los cambios?", "Cambios no guardados",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }

        }

        #endregion

        #region Métodos

        public void CargarGrilla(Entidades.Colecciones colecciones)
        {
            foreach (Entidades.Coleccion coleccion in colecciones)
            {
                float precioVentaVigente = ObtenerPrecioVentaVigente(coleccion.Id_colec);

                dgvListadoColecciones.Rows.Add(coleccion.Id_colec,
                                               coleccion.Cod_colec,
                                               coleccion.Titulo_colec,
                                               coleccion.PrecioCompra,
                                               precioVentaVigente,
                                               precioVentaVigente);
            }
        }

        public float ObtenerPrecioVentaVigente(int id_colec)
        {
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            return nColeccion.ObtenerPrecioVentaVigente(id_colec);
        }

        public void ValidarCeldasEditables(int indiceCol, int indiceRow)
        {
            //Puse un switch en caso de que en el futuro se le agreguen mas celdas editables
            switch (indiceCol)
            {
                case 5: //Columna PrecioVentaNuevo
                    if (dgvListadoColecciones.Rows[indiceRow].Cells["colPrecioVentaNuevo"].Value == DBNull.Value ||
                        float.Parse(dgvListadoColecciones.Rows[indiceRow].Cells["colPrecioVentaNuevo"].Value.ToString()) < 0)
                    {
                        //Hace falta convertirlo a float?
                        dgvListadoColecciones.Rows[indiceRow].Cells["colPrecioVentaNuevo"].Value =
                        dgvListadoColecciones.Rows[indiceRow].Cells["colPrecioVentaVigente"].Value;
                    }
                    break;
                default:
                    break;
            }

        }

        public void GuardarPrecios()
        {
            Negocio.Colecciones nColeccion = new HP.Negocio.Colecciones();
            foreach (DataGridViewRow row in dgvListadoColecciones.Rows)
            {
                nColeccion.ActualizarPrecioVenta(Convert.ToInt32(row.Cells["colIdColec"].Value),
                                                 float.Parse(row.Cells["colPrecioVentaNuevo"].Value.ToString()));
            }
            MessageBox.Show("Los nuevos precios de venta han sido registrados satisfactoriamente",
                            "Datos Guardados",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
        
    }
}