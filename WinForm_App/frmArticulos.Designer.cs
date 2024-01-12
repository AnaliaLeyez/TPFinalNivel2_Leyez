namespace WinForm_App
{
    partial class FrmArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtboxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtboxFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panelFiltroAv = new System.Windows.Forms.Panel();
            this.lblDescNombre = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblDescPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).BeginInit();
            this.panelFiltroAv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvArticulos.Location = new System.Drawing.Point(40, 158);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 82;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1066, 232);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(210, 464);
            this.pboxArticulo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(389, 556);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulo.TabIndex = 1;
            this.pboxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(205)))), ((int)(((byte)(82)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(1195, 158);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 64);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Location = new System.Drawing.Point(51, 945);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 59);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(611, 945);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 59);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtboxFiltroAvanzado
            // 
            this.txtboxFiltroAvanzado.Location = new System.Drawing.Point(700, 43);
            this.txtboxFiltroAvanzado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtboxFiltroAvanzado.Name = "txtboxFiltroAvanzado";
            this.txtboxFiltroAvanzado.Size = new System.Drawing.Size(395, 31);
            this.txtboxFiltroAvanzado.TabIndex = 29;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(628, 43);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(68, 29);
            this.lblFiltroAvanzado.TabIndex = 28;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(307, 43);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(92, 29);
            this.lblCriterio.TabIndex = 27;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(400, 40);
            this.cboxCriterio.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(196, 33);
            this.cboxCriterio.TabIndex = 26;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(6, 40);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(91, 29);
            this.lblCampo.TabIndex = 25;
            this.lblCampo.Text = "Campo";
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(98, 37);
            this.cboxCampo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(174, 33);
            this.cboxCampo.TabIndex = 24;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrar.Location = new System.Drawing.Point(1144, 32);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(144, 52);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtboxFiltro
            // 
            this.txtboxFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.txtboxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFiltro.Location = new System.Drawing.Point(210, 408);
            this.txtboxFiltro.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtboxFiltro.Name = "txtboxFiltro";
            this.txtboxFiltro.Size = new System.Drawing.Size(545, 35);
            this.txtboxFiltro.TabIndex = 31;
            this.txtboxFiltro.TextChanged += new System.EventHandler(this.txtboxFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(46, 408);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(152, 29);
            this.lblFiltro.TabIndex = 30;
            this.lblFiltro.Text = "Filtro Rápido";
            // 
            // panelFiltroAv
            // 
            this.panelFiltroAv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.panelFiltroAv.Controls.Add(this.lblCampo);
            this.panelFiltroAv.Controls.Add(this.btnFiltrar);
            this.panelFiltroAv.Controls.Add(this.cboxCampo);
            this.panelFiltroAv.Controls.Add(this.cboxCriterio);
            this.panelFiltroAv.Controls.Add(this.lblCriterio);
            this.panelFiltroAv.Controls.Add(this.lblFiltroAvanzado);
            this.panelFiltroAv.Controls.Add(this.txtboxFiltroAvanzado);
            this.panelFiltroAv.Location = new System.Drawing.Point(40, 31);
            this.panelFiltroAv.Name = "panelFiltroAv";
            this.panelFiltroAv.Size = new System.Drawing.Size(1305, 101);
            this.panelFiltroAv.TabIndex = 35;
            // 
            // lblDescNombre
            // 
            this.lblDescNombre.AutoSize = true;
            this.lblDescNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescNombre.Location = new System.Drawing.Point(630, 558);
            this.lblDescNombre.Name = "lblDescNombre";
            this.lblDescNombre.Size = new System.Drawing.Size(153, 38);
            this.lblDescNombre.TabIndex = 36;
            this.lblDescNombre.Text = "Nombre";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescMarca.Location = new System.Drawing.Point(630, 652);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(122, 38);
            this.lblDescMarca.TabIndex = 37;
            this.lblDescMarca.Text = "Marca";
            // 
            // lblDescPrecio
            // 
            this.lblDescPrecio.AutoSize = true;
            this.lblDescPrecio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescPrecio.Location = new System.Drawing.Point(630, 749);
            this.lblDescPrecio.Name = "lblDescPrecio";
            this.lblDescPrecio.Size = new System.Drawing.Size(122, 38);
            this.lblDescPrecio.TabIndex = 38;
            this.lblDescPrecio.Text = "Precio";
            // 
            // FrmArticulos
            // 
            this.AccessibleDescription = "Formulario de artículos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1389, 1033);
            this.Controls.Add(this.lblDescPrecio);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblDescNombre);
            this.Controls.Add(this.panelFiltroAv);
            this.Controls.Add(this.txtboxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FrmArticulos";
            this.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).EndInit();
            this.panelFiltroAv.ResumeLayout(false);
            this.panelFiltroAv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pboxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtboxFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtboxFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel panelFiltroAv;
        private System.Windows.Forms.Label lblDescNombre;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblDescPrecio;
    }
}

