using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HP.Presentacion
{
    public partial class frmListadoPedidosPendientes : Form
    {
        #region Variables Globales

        Entidades.Proveedores proveedores;

        #endregion


        #region Constructor

        public frmListadoPedidosPendientes()
        {
            InitializeComponent();
            CargarComboboxProveedores();
            cbxProveedor.SelectedIndex = 0;
        }
        
        #endregion


        #region Eventos

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPedidosPendientes(ObtenerIdProveedor(cbxProveedor.SelectedItem.ToString()));
        }

        private void btnMostrarDetalles_Click(object sender, EventArgs e)
        {
            MostrarDetallesPedido();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarPedido();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Metodos

        public void CargarComboboxProveedores()
        {
            Negocio.Proveedores nProveedores = new HP.Negocio.Proveedores();
            proveedores = nProveedores.ObtenerHabilitados();

            foreach (Entidades.Proveedor proveedor in proveedores)
            {
                cbxProveedor.Items.Add(proveedor.Razon_social);
            }
        }

        public int ObtenerIdProveedor(string razon_social)
        {
            foreach (Entidades.Proveedor proveedor in proveedores)
            {
                if (razon_social == proveedor.Razon_social)
                { return proveedor.Id_prov; }
            }
            //Si todavia no se devolvio ningun id_prov es porque se selecciono "todos" y devuelvo "0"
            return 0;
        }

        public void CargarPedidosPendientes(int id_prov)
        {
            dgvListadoPedidosPendientes.Rows.Clear();
            Negocio.Compras nCompras = new HP.Negocio.Compras();

            if (id_prov == 0)
            {
                if (!dgvListadoPedidosPendientes.Columns["colProveedor"].Visible)
                {
                    dgvListadoPedidosPendientes.Columns["colProveedor"].Visible = true;
                    dgvListadoPedidosPendientes.Columns["colNroPedido"].Width = 95;
                    dgvListadoPedidosPendientes.Columns["colFechaPedido"].Width = 110;
                }
                Entidades.Compras compras = nCompras.ObtenerPendientesTodos();
                foreach (Entidades.Compra compra in compras)
                {
                    dgvListadoPedidosPendientes.Rows.Add(compra.Id_Compra,
                                                         compra.Fecha_Pedido.ToShortDateString(),
                                                         compra.Prov.Razon_social);
                }

            }
            else
            {
                if (dgvListadoPedidosPendientes.Columns["colProveedor"].Visible)
                { 
                    dgvListadoPedidosPendientes.Columns["colProveedor"].Visible = false;
                    dgvListadoPedidosPendientes.Columns["colNroPedido"].Width = 155;
                    dgvListadoPedidosPendientes.Columns["colFechaPedido"].Width = 170;
                }
                Entidades.Compras compras = nCompras.ObtenerPendientesUnProveedor(id_prov);

                foreach (Entidades.Compra compra in compras)
                {
                    dgvListadoPedidosPendientes.Rows.Add(compra.Id_Compra, compra.Fecha_Pedido.ToShortDateString());
                }
            }
        }

        public void MostrarDetallesPedido()
        {
            if (dgvListadoPedidosPendientes.SelectedRows.Count == 1)
            {
                //Al haber una sola seleccionada, la misma tendra el indice 0 en la coleccion de rows recuperadas con "SelectedRows"
                if (new frmDetallePedido(Convert.ToInt32(dgvListadoPedidosPendientes.SelectedRows[0].Cells["colNroPedido"].Value)).ShowDialog()
                    == DialogResult.Yes)
                { dgvListadoPedidosPendientes.Rows.Remove(dgvListadoPedidosPendientes.SelectedRows[0]); }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun pedido", "Mostrar Detalles del Pedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarPedido()
        {
            if (dgvListadoPedidosPendientes.SelectedRows.Count == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Esta seguro de querer cancelar el pedido seleccionado?", "Cancelar Pedido",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Negocio.Compras nCompras = new HP.Negocio.Compras();
                    nCompras.Cancelar(Convert.ToInt32(dgvListadoPedidosPendientes.SelectedRows[0].Cells["colNroPedido"].Value));
                    dgvListadoPedidosPendientes.Rows.Remove(dgvListadoPedidosPendientes.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun pedido", "Cancelar Pedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}