namespace HP.Presentacion
{
    partial class frmAgregarNC
    {
        /// <summary>
        /// Variable del disenador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Disenador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Disenador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dgvListadoNotasDeCredito = new System.Windows.Forms.DataGridView();
            this.btnAgregarSeleccionadas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloMontoACubrir = new System.Windows.Forms.Label();
            this.lblMontoACubrir = new System.Windows.Forms.Label();
            this.colIdNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotasDeCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(12, 9);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(189, 13);
            this.lblTituloProveedor.TabIndex = 0;
            this.lblTituloProveedor.Text = "Notas de Crédito del Proveedor:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(207, 9);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 13);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Darken S.A.";
            // 
            // dgvListadoNotasDeCredito
            // 
            this.dgvListadoNotasDeCredito.AllowUserToAddRows = false;
            this.dgvListadoNotasDeCredito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListadoNotasDeCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoNotasDeCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoNotasDeCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoNotasDeCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNotasDeCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNC,
            this.colCodNC,
            this.colFechaEmision,
            this.colMontoOriginal,
            this.colSaldoRestante});
            this.dgvListadoNotasDeCredito.Location = new System.Drawing.Point(12, 25);
            this.dgvListadoNotasDeCredito.Name = "dgvListadoNotasDeCredito";
            this.dgvListadoNotasDeCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoNotasDeCredito.Size = new System.Drawing.Size(462, 122);
            this.dgvListadoNotasDeCredito.TabIndex = 2;
            // 
            // btnAgregarSeleccionadas
            // 
            this.btnAgregarSeleccionadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarSeleccionadas.Location = new System.Drawing.Point(268, 161);
            this.btnAgregarSeleccionadas.Name = "btnAgregarSeleccionadas";
            this.btnAgregarSeleccionadas.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarSeleccionadas.TabIndex = 3;
            this.btnAgregarSeleccionadas.Text = "Agregar Seleccionadas";
            this.btnAgregarSeleccionadas.UseVisualStyleBackColor = true;
            this.btnAgregarSeleccionadas.Click += new System.EventHandler(this.btnAgregarSeleccionadas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(399, 160);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTituloMontoACubrir
            // 
            this.lblTituloMontoACubrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloMontoACubrir.AutoSize = true;
            this.lblTituloMontoACubrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMontoACubrir.Location = new System.Drawing.Point(305, 6);
            this.lblTituloMontoACubrir.Name = "lblTituloMontoACubrir";
            this.lblTituloMontoACubrir.Size = new System.Drawing.Size(94, 13);
            this.lblTituloMontoACubrir.TabIndex = 5;
            this.lblTituloMontoACubrir.Text = "Monto a Cubrir:";
            // 
            // lblMontoACubrir
            // 
            this.lblMontoACubrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoACubrir.AutoSize = true;
            this.lblMontoACubrir.Location = new System.Drawing.Point(405, 6);
            this.lblMontoACubrir.Name = "lblMontoACubrir";
            this.lblMontoACubrir.Size = new System.Drawing.Size(13, 13);
            this.lblMontoACubrir.TabIndex = 6;
            this.lblMontoACubrir.Text = "$";
            // 
            // colIdNC
            // 
            this.colIdNC.Frozen = true;
            this.colIdNC.HeaderText = "IdNC";
            this.colIdNC.Name = "colIdNC";
            this.colIdNC.ReadOnly = true;
            this.colIdNC.Visible = false;
            this.colIdNC.Width = 50;
            // 
            // colCodNC
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colCodNC.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCodNC.Frozen = true;
            this.colCodNC.HeaderText = "Codigo NC";
            this.colCodNC.Name = "colCodNC";
            this.colCodNC.ReadOnly = true;
            // 
            // colFechaEmision
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colFechaEmision.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFechaEmision.HeaderText = "Fecha Emisión";
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.ReadOnly = true;
            // 
            // colMontoOriginal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colMontoOriginal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colMontoOriginal.HeaderText = "Monto Original";
            this.colMontoOriginal.Name = "colMontoOriginal";
            this.colMontoOriginal.ReadOnly = true;
            // 
            // colSaldoRestante
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.colSaldoRestante.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSaldoRestante.HeaderText = "Saldo Restante";
            this.colSaldoRestante.Name = "colSaldoRestante";
            this.colSaldoRestante.ReadOnly = true;
            // 
            // frmAgregarNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 192);
            this.Controls.Add(this.lblMontoACubrir);
            this.Controls.Add(this.lblTituloMontoACubrir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarSeleccionadas);
            this.Controls.Add(this.dgvListadoNotasDeCredito);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTituloProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Nota de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotasDeCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView dgvListadoNotasDeCredito;
        private System.Windows.Forms.Button btnAgregarSeleccionadas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloMontoACubrir;
        private System.Windows.Forms.Label lblMontoACubrir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoRestante;
    }
}