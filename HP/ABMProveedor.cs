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
    public partial class frmABMProveedor : Form
    {
        #region Variables Globales

        Entidades.Proveedor proveedorAuxiliar;

        #endregion

        #region Constructor

        public frmABMProveedor()
        {
            InitializeComponent();
            m_operacion = tipoOperacion.Agregar;
            CargarGrilla();
        }

        #endregion

        #region Enumerador

        public enum tipoOperacion
        {
            Agregar = 0,
            Editar = 1
        }

        #endregion

        #region Propiedades

        private tipoOperacion m_operacion;

        public tipoOperacion M_Operacion
        {
            get { return m_operacion; }
            set { m_operacion = value; }
        }

        #endregion

        #region Eventos

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            EstablecerHabilitacion();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            EstablecerHabilitacion();
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count != 0)
            {
                if (dgvProveedores.SelectedRows[0].Cells["colEstado"].Value.ToString().Equals("Habilitado"))
                {
                    btnHabilitar.Enabled = false;
                    btnDeshabilitar.Enabled = true;
                }
                else
                {
                    btnHabilitar.Enabled = true;
                    btnDeshabilitar.Enabled = false;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            m_operacion = tipoOperacion.Editar;
            gbxFormulario.Text = "Editar Proveedor";
            CargarFormulario();
            proveedorAuxiliar = new HP.Entidades.Proveedor();
            proveedorAuxiliar.Id_prov = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["colId_Prov"].Value);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarDatosProveedor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarFormulario();
            m_operacion = tipoOperacion.Agregar;
            gbxFormulario.Text = "Agregar Proveedor";
            proveedorAuxiliar = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        public void CargarGrilla()
        {
            String estado = "";

            this.dgvProveedores.Rows.Clear();

            Negocio.Proveedores nProveedores = new HP.Negocio.Proveedores();
            Entidades.Proveedores pProveedores = nProveedores.ObtenerTodos();

            foreach (Entidades.Proveedor pProveedor in pProveedores)
            {
                if (pProveedor.Habilitado)
                    estado = "Habilitado";
                else
                    estado = "Deshabilitado";

                this.dgvProveedores.Rows.Add(pProveedor.Id_prov, pProveedor.Razon_social,
                                            pProveedor.Cuit_prov, pProveedor.Telefono,
                                            pProveedor.Email_prov,// pProveedor.Nro_cta_bca,
                                            estado);

                if (!pProveedor.Habilitado)
                {
                    int indiceUltimaFila = (this.dgvProveedores.Rows.Count - 1);
                    this.dgvProveedores.Rows[indiceUltimaFila].DefaultCellStyle.ForeColor = Color.Red;
                    this.dgvProveedores.Rows[indiceUltimaFila].Cells["colEstado"].Style.Font = new Font(Font, FontStyle.Bold);

                }
            }

        }

        public void EstablecerHabilitacion()
        {
            Negocio.Proveedores nProveedor = new HP.Negocio.Proveedores();

            int id_prov = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["colId_Prov"].Value);

            //Si el proveedor esta habilitado, lo deshabilito y viceversa
            if (dgvProveedores.SelectedRows[0].Cells["colEstado"].Value.ToString() == "Habilitado")
            {
                //Antes de deshabilitarlo chequeo que no tenga pedidos pendientes
                Entidades.Compras compras = nProveedor.ValidarPedidosPendientes(id_prov);
                if (compras.Count == 0)
                { nProveedor.EstablecerHabilitacion(id_prov, 0); }
                else
                {
                    string mensaje = "El proveedor que desea deshabilitar todavía tiene los siguientes pedidos pendientes:" +
                                      "\n\nCódigo de Pedido\tFecha de Pedido\n";
                    foreach (Entidades.Compra compra in compras)
                    { mensaje += "\t" + compra.Id_Compra.ToString() + "\t" +
                                compra.Fecha_Pedido.ToShortDateString() + "\n"; }
                    mensaje += "\nDebe confirmar la recepción de los mismos o cancelarlos.";

                    MessageBox.Show(mensaje, "Deshabilitación denegada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            { nProveedor.EstablecerHabilitacion(id_prov, 1); }

            

            CargarGrilla();
        }

        public bool ValidarCamposFormulario()
        {
            String mensaje = "";

            if (tbxCuit.Text.Trim() == "")
                mensaje += "El CUIT no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxCuit.Text.Trim(), @"^(\d{9,11})$"))
                mensaje += "El formato del CUIT es incorrecto. Se deben ingresar entre " +
                            "9 y 11 dígitos positivos. Ejemplo: 27327349025\n";
           
            if (tbxEmail.Text.Trim() == "")
                mensaje += "El E-MAIL no puede estar en blanco.\n";
            else if (tbxEmail.Text.IndexOf(".") == -1 || tbxEmail.Text.IndexOf("@") == -1)
                mensaje += "El formato del E-MAIL es incorrecto. Ejemplo: arcor@gmail.com.\n";
/*
            if (tbxNroCtaBca.Text.Trim() == "")
                mensaje += "El Nº de CUENTA BANCARIA no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxNroCtaBca.Text.Trim(), @"^\d{12}$"))
                mensaje += "El formato del Nº de CUENTA BANCARIA es incorrecto. Deben " +
                            "ingresarse 12 digitos. Ejemplo: 123456789012.\n";
*/
            if (tbxRazonSocial.Text.Trim() == "")
                mensaje += "La RAZÓN SOCIAL no puede estar en blanco.\n";

            if (tbxTelefono.Text.Trim() == "")
                mensaje += "El TELEFONO no puede estar en blanco.\n";
            else if (!Regex.IsMatch(tbxTelefono.Text.Trim(), @"^(\d{5,20})$"))
                mensaje += "El formato del TELEFONO es incorrecto. Deben ingresarse entre " +
                            "5 y 20 dígitos. Ejemplo: 4219563.\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxRazonSocial.Focus();
                tbxRazonSocial.SelectAll();
                return false;
            }
            return true;
        }

        public void VaciarFormulario()
        {
            tbxCuit.Text = "";
            tbxEmail.Text = "";
            //tbxNroCtaBca.Text = "";
            tbxRazonSocial.Text = "";
            tbxTelefono.Text = "";
        }

        public void ObtenerDatosFormulario()
        {
            proveedorAuxiliar.Cuit_prov = Convert.ToInt64(tbxCuit.Text.Trim());
            proveedorAuxiliar.Email_prov = tbxEmail.Text.Trim();
            //proveedorAuxiliar.Nro_cta_bca = Convert.ToInt64(tbxNroCtaBca.Text.Trim());
            proveedorAuxiliar.Razon_social = tbxRazonSocial.Text.Trim();
            proveedorAuxiliar.Telefono = tbxTelefono.Text.Trim();
        }

        public void GuardarDatosProveedor()
        {
            if (ValidarCamposFormulario())
            {
                if (m_operacion == tipoOperacion.Agregar)
                {
                    proveedorAuxiliar = new HP.Entidades.Proveedor();
                    ObtenerDatosFormulario();
                    AgregarProveedor(proveedorAuxiliar);
                }
                else
                {
                    ObtenerDatosFormulario();
                    EditarProveedor(proveedorAuxiliar);
                }
                proveedorAuxiliar = null;
            }
        }

        public void AgregarProveedor(Entidades.Proveedor oProveedor)
        {
            Negocio.Proveedores nProveedor = new HP.Negocio.Proveedores();
            
            //Si ya existe el proveedor se devuelve "-1"//
            if (nProveedor.Agregar(oProveedor) == -1)
            {
                MessageBox.Show("El CUIT y/o la RAZÓN SOCIAL ingresada ya existen",
                        "Proveedor Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxRazonSocial.Focus();
                tbxRazonSocial.SelectAll();
            }
            else
            {
                VaciarFormulario();
                CargarGrilla();
            }
        }

        public void EditarProveedor(Entidades.Proveedor oProveedor)
        {
            Negocio.Proveedores nProveedor = new HP.Negocio.Proveedores();

            //Si ya existe el proveedor se devuelve "-1"//
            if (nProveedor.Editar(oProveedor) == -1)
            {
                MessageBox.Show("El CUIT y/o la RAZÓN SOCIAL ingresada pertenecen a otro proveedor ya existente",
                        "Proveedor Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxRazonSocial.Focus();
                tbxRazonSocial.SelectAll();
            }
            else
            {
                VaciarFormulario();
                m_operacion = tipoOperacion.Agregar;
                gbxFormulario.Text = "Agregar Proveedor";
                CargarGrilla();
            }
        }

        public void CargarFormulario()
        {
            tbxRazonSocial.Text = (dgvProveedores.SelectedRows[0].Cells["colRazonSocial"].Value).ToString();
            tbxCuit.Text = (dgvProveedores.SelectedRows[0].Cells["colCuit"].Value).ToString();
            tbxTelefono.Text = (dgvProveedores.SelectedRows[0].Cells["colTelefono"].Value).ToString();
            tbxEmail.Text = (dgvProveedores.SelectedRows[0].Cells["colEmail"].Value).ToString();
            //tbxNroCtaBca.Text = (dgvProveedores.SelectedRows[0].Cells["colNroCtaBca"].Value).ToString();
        }

        #endregion
    }
}