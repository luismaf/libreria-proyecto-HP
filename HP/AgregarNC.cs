using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HP.Presentacion
{
    public partial class frmAgregarNC : Form
    {
        #region Propiedades

        Entidades.Notas_Credito notas_Agregadas;

        public Entidades.Notas_Credito Notas_Agregadas
        {
            get { return notas_Agregadas; }
            set { notas_Agregadas = value; }
        }

        #endregion


        #region constructor

        public frmAgregarNC(float? saldoRestante, int id_prov, string razon_social)
        {
            InitializeComponent();
            lblProveedor.Text = razon_social;
            lblMontoACubrir.Text = "$" + saldoRestante.ToString();
            CargarNotasCredito(id_prov);
        }

        #endregion


        #region Eventos

        private void btnAgregarSeleccionadas_Click(object sender, EventArgs e)
        {
            AgregarNotasCredito();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Metodos

        public void CargarNotasCredito(int id_prov)
        {
            Negocio.Notas_Credito nNotas_Credito = new HP.Negocio.Notas_Credito();

            foreach (Entidades.Nota_Credito nota in nNotas_Credito.ObtenerTodasConSaldoUnProveedor(id_prov))
            {
                dgvListadoNotasDeCredito.Rows.Add(nota.Id_Nota_Credito, nota.Codigo_Nc, nota.Fecha_Emision.ToShortDateString(),
                                                nota.Monto_Total_Nc, nota.Saldo_Restante);
            }
        }

        public void AgregarNotasCredito()
        {
            notas_Agregadas = new HP.Entidades.Notas_Credito();
            Entidades.Nota_Credito nota;
            foreach (DataGridViewRow row in dgvListadoNotasDeCredito.SelectedRows)
            {
                nota = new HP.Entidades.Nota_Credito();
                nota.Id_Nota_Credito = Convert.ToInt32(row.Cells["colIdNC"].Value);
                nota.Codigo_Nc = Convert.ToInt32(row.Cells["colCodNC"].Value);
                nota.Fecha_Emision = Convert.ToDateTime(row.Cells["colFechaEmision"].Value);
                nota.Monto_Total_Nc = float.Parse(row.Cells["colMontoOriginal"].Value.ToString());
                nota.Saldo_Restante = float.Parse(row.Cells["colSaldoRestante"].Value.ToString());

                notas_Agregadas.Add(nota);
            }
            notas_Agregadas.Reverse();
            this.Close();
        }

        #endregion
    }
}