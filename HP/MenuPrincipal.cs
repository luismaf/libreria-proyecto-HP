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
    public partial class frmMenuPrincipal : Form
    {
        #region Constructor

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void btnABMLibros_Click(object sender, EventArgs e)
        {
            CargarFrmABMLibros();
        }

        private void btnABMProveedor_Click(object sender, EventArgs e)
        {
            CargarFrmABMProovedor();
        }

        private void btnListadoDeFaltantes_Click(object sender, EventArgs e)
        {
            CargarFrmListadoFaltantes();
        }

        private void btnListadoDePedidosPendientes_Click(object sender, EventArgs e)
        {
            CargarFrmListadoPedidosPendientes();
        }

        private void btnConsultarLibros_Click(object sender, EventArgs e)
        {
            CargarFrmBuscarInfoLibro();
        }

        private void btnVenderLibros_Click(object sender, EventArgs e)
        {
            CargarFrmVenta();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            CargarFrmNuevoCliente();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            RealizarBackUp();
        }

        private void btnRestaurarBase_Click(object sender, EventArgs e)
        {
            RestaurarBase();
        }

        private void frmMenuPrincipal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MostrarAyuda();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
        #endregion

        #region Metodos

        public void CargarFrmABMLibros()
        {
            new frmABMLibros().ShowDialog();
        }

        public void CargarFrmABMProovedor()
        {
            new frmABMProveedor().ShowDialog();
        }

        public void CargarFrmListadoFaltantes()
        {
            new frmListadoFaltantes().ShowDialog();
        }

        public void CargarFrmListadoPedidosPendientes()
        {
            new frmListadoPedidosPendientes().ShowDialog();
        }

        public void CargarFrmBuscarInfoLibro()
        {
            new frmBuscarInfoLibros().ShowDialog();
        }

        public void CargarFrmVenta()
        {
            new frmVenta().ShowDialog();
        }

        public void CargarFrmNuevoCliente()
        {
            new frmNuevoCliente().ShowDialog();
        }

        public void RealizarBackUp()
        {
            DialogResult dResult;
            bool rutaValida = false;
            do
            {
                dResult = sfdBackUp.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    rutaValida = Regex.IsMatch(sfdBackUp.FileName, @"\.bak$");
                    if (rutaValida)
                    {
                        Negocio.General nGeneral = new HP.Negocio.General();
                        int respuesta = nGeneral.RealizarBackUpCompleto(sfdBackUp.FileName);

                        if (respuesta != -1)
                        {
                            MessageBox.Show("El Back Up se realiz� con �xito.", "Back Up Realizado",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar el Back Up debido a un error " +
                                            "en la base de datos.", "Back Up NO realizado",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre de archivo ingresado no es v�lido.\n" + 
                            "Debe finalizar con \".bak\" o no especificar ninguna extensi�n.",
                            "Nombre de archivo inv�lido", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
            }
            while (dResult == DialogResult.OK && !rutaValida);
        }

        public void RestaurarBase()
        {
            DialogResult dResult;
            bool rutaValida = false;
            do
            {
                dResult = ofdRestaurarBase.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    rutaValida = Regex.IsMatch(ofdRestaurarBase.FileName, @"\.bak$");
                    if (rutaValida)
                    {
                        Negocio.General nGeneral = new HP.Negocio.General();
                        int respuesta = nGeneral.RestaurarBase(ofdRestaurarBase.FileName);

                        if (respuesta != -1)
                        {
                            MessageBox.Show("La base de datos ha sido restaurada con �xito.",
                                            "Base de Datos Restaurada",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo restaurar la base de datos.\n" +
                                            "Asegures� de que la base de datos que intenta " +
                                            "restaurar no se encuentra en uso actualmente.\n" +
                                            "Si el problema persiste, cierre la aplicaci�n, " +
                                            "vuelva a abrirla, e intente restaurar la base " +
                                            "antes de realizar cualquier otra operaci�n",
                                            "Base de Datos NO Restaurada",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado no es un archivo " +
                            "v�lido con el cual puede restaurar la base de datos.\n" +
                            "Por favor, seleccione un archivo v�lido.",
                            "Archivo inv�lido", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
            }
            while (dResult == DialogResult.OK && !rutaValida);
        }

        public void MostrarAyuda()
        {
            Negocio.Ayuda nAyuda = new HP.Negocio.Ayuda();
            Help.ShowHelp(this, nAyuda.URLAyuda());
        }
        
        #endregion
    }
}