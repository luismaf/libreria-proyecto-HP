namespace HP.Presentacion
{
    partial class frmElementosDeshabilitados
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
            this.dgvElementosDeshabilitados = new System.Windows.Forms.DataGridView();
            this.colIdCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitadaCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitadaColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloColec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblNegro = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosDeshabilitados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElementosDeshabilitados
            // 
            this.dgvElementosDeshabilitados.AllowUserToAddRows = false;
            this.dgvElementosDeshabilitados.AllowUserToDeleteRows = false;
            this.dgvElementosDeshabilitados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElementosDeshabilitados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvElementosDeshabilitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementosDeshabilitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCateg,
            this.colHabilitadaCateg,
            this.colNombreCateg,
            this.colIdColec,
            this.colHabilitadaColec,
            this.colTituloColec,
            this.colIdLibro,
            this.colTituloLibro});
            this.dgvElementosDeshabilitados.Location = new System.Drawing.Point(12, 12);
            this.dgvElementosDeshabilitados.MultiSelect = false;
            this.dgvElementosDeshabilitados.Name = "dgvElementosDeshabilitados";
            this.dgvElementosDeshabilitados.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgvElementosDeshabilitados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvElementosDeshabilitados.Size = new System.Drawing.Size(765, 270);
            this.dgvElementosDeshabilitados.TabIndex = 0;
            // 
            // colIdCateg
            // 
            this.colIdCateg.Frozen = true;
            this.colIdCateg.HeaderText = "Id Categoria";
            this.colIdCateg.Name = "colIdCateg";
            this.colIdCateg.ReadOnly = true;
            this.colIdCateg.Visible = false;
            // 
            // colHabilitadaCateg
            // 
            this.colHabilitadaCateg.Frozen = true;
            this.colHabilitadaCateg.HeaderText = "Categoria Habilitada";
            this.colHabilitadaCateg.Name = "colHabilitadaCateg";
            this.colHabilitadaCateg.ReadOnly = true;
            this.colHabilitadaCateg.Visible = false;
            // 
            // colNombreCateg
            // 
            this.colNombreCateg.Frozen = true;
            this.colNombreCateg.HeaderText = "Categoría";
            this.colNombreCateg.Name = "colNombreCateg";
            this.colNombreCateg.ReadOnly = true;
            this.colNombreCateg.Width = 200;
            // 
            // colIdColec
            // 
            this.colIdColec.Frozen = true;
            this.colIdColec.HeaderText = "Id Coleccion";
            this.colIdColec.Name = "colIdColec";
            this.colIdColec.ReadOnly = true;
            this.colIdColec.Visible = false;
            // 
            // colHabilitadaColec
            // 
            this.colHabilitadaColec.Frozen = true;
            this.colHabilitadaColec.HeaderText = "Colección Habilitada";
            this.colHabilitadaColec.Name = "colHabilitadaColec";
            this.colHabilitadaColec.ReadOnly = true;
            this.colHabilitadaColec.Visible = false;
            // 
            // colTituloColec
            // 
            this.colTituloColec.Frozen = true;
            this.colTituloColec.HeaderText = "Colección";
            this.colTituloColec.Name = "colTituloColec";
            this.colTituloColec.ReadOnly = true;
            this.colTituloColec.Width = 250;
            // 
            // colIdLibro
            // 
            this.colIdLibro.Frozen = true;
            this.colIdLibro.HeaderText = "Id Libro";
            this.colIdLibro.Name = "colIdLibro";
            this.colIdLibro.ReadOnly = true;
            this.colIdLibro.Visible = false;
            // 
            // colTituloLibro
            // 
            this.colTituloLibro.Frozen = true;
            this.colTituloLibro.HeaderText = "Libro";
            this.colTituloLibro.Name = "colTituloLibro";
            this.colTituloLibro.ReadOnly = true;
            this.colTituloLibro.Width = 250;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHabilitar.Location = new System.Drawing.Point(590, 289);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 1;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRojo.AutoSize = true;
            this.lblRojo.ForeColor = System.Drawing.Color.Red;
            this.lblRojo.Location = new System.Drawing.Point(12, 289);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(189, 13);
            this.lblRojo.TabIndex = 2;
            this.lblRojo.Text = "Color Rojo:   Elementos Deshabilitados";
            // 
            // lblNegro
            // 
            this.lblNegro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNegro.AutoSize = true;
            this.lblNegro.Location = new System.Drawing.Point(12, 306);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(173, 13);
            this.lblNegro.TabIndex = 3;
            this.lblNegro.Text = "Color Negro: Elementos Habilitados";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(702, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmElementosDeshabilitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 324);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNegro);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.dgvElementosDeshabilitados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmElementosDeshabilitados";
            this.Text = "Elementos Deshabilitados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmElementosDeshabilitados_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementosDeshabilitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElementosDeshabilitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabilitadaCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabilitadaColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloColec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloLibro;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblNegro;
        private System.Windows.Forms.Button btnVolver;
    }
}