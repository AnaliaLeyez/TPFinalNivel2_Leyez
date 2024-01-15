using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtboxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.txtboxFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panelFiltroAv = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblDescNombre = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblDescPrecio = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuAgregarArt = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuAgregarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenucerrarApp = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenuCreador = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pboxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelFiltroAv.SuspendLayout();
            this.menuAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvArticulos.Location = new System.Drawing.Point(352, 229);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(1766, 232);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(1066, 232);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 82;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowTemplate.Height = 33;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1066, 232);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditar.Location = new System.Drawing.Point(-1, 455);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(250, 109);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(-1, 857);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(250, 109);
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
            this.txtboxFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxFiltroAvanzado_KeyPress);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.Color.White;
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
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
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
            this.lblCampo.ForeColor = System.Drawing.Color.White;
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
            // txtboxFiltro
            // 
            this.txtboxFiltro.BackColor = System.Drawing.Color.White;
            this.txtboxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtboxFiltro.Location = new System.Drawing.Point(470, 169);
            this.txtboxFiltro.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtboxFiltro.Name = "txtboxFiltro";
            this.txtboxFiltro.Size = new System.Drawing.Size(545, 38);
            this.txtboxFiltro.TabIndex = 31;
            this.txtboxFiltro.TextChanged += new System.EventHandler(this.txtboxFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(268, 169);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(165, 29);
            this.lblFiltro.TabIndex = 30;
            this.lblFiltro.Text = "Filtro Rápido";
            // 
            // panelFiltroAv
            // 
            this.panelFiltroAv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltroAv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelFiltroAv.Controls.Add(this.btnClearFilter);
            this.panelFiltroAv.Controls.Add(this.lblCampo);
            this.panelFiltroAv.Controls.Add(this.btnFiltrar);
            this.panelFiltroAv.Controls.Add(this.cboxCampo);
            this.panelFiltroAv.Controls.Add(this.cboxCriterio);
            this.panelFiltroAv.Controls.Add(this.lblCriterio);
            this.panelFiltroAv.Controls.Add(this.lblFiltroAvanzado);
            this.panelFiltroAv.Controls.Add(this.txtboxFiltroAvanzado);
            this.panelFiltroAv.Location = new System.Drawing.Point(273, 43);
            this.panelFiltroAv.Name = "panelFiltroAv";
            this.panelFiltroAv.Size = new System.Drawing.Size(1305, 101);
            this.panelFiltroAv.TabIndex = 35;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnClearFilter.Image = global::WinForm_App.Properties.Resources.Undo;
            this.btnClearFilter.Location = new System.Drawing.Point(1218, 35);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(60, 52);
            this.btnClearFilter.TabIndex = 0;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Image = global::WinForm_App.Properties.Resources.Filter;
            this.btnFiltrar.Location = new System.Drawing.Point(1122, 32);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(60, 52);
            this.btnFiltrar.TabIndex = 23;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblDescNombre
            // 
            this.lblDescNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescNombre.AutoSize = true;
            this.lblDescNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescNombre.Location = new System.Drawing.Point(925, 569);
            this.lblDescNombre.Name = "lblDescNombre";
            this.lblDescNombre.Size = new System.Drawing.Size(153, 38);
            this.lblDescNombre.TabIndex = 36;
            this.lblDescNombre.Text = "Nombre";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescMarca.Location = new System.Drawing.Point(925, 663);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(122, 38);
            this.lblDescMarca.TabIndex = 37;
            this.lblDescMarca.Text = "Marca";
            // 
            // lblDescPrecio
            // 
            this.lblDescPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescPrecio.AutoSize = true;
            this.lblDescPrecio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescPrecio.Location = new System.Drawing.Point(925, 760);
            this.lblDescPrecio.Name = "lblDescPrecio";
            this.lblDescPrecio.Size = new System.Drawing.Size(122, 38);
            this.lblDescPrecio.TabIndex = 38;
            this.lblDescPrecio.Text = "Precio";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.Black;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBaja.Location = new System.Drawing.Point(0, 657);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(250, 109);
            this.btnBaja.TabIndex = 39;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnReactivar
            // 
            this.btnReactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnReactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReactivar.Location = new System.Drawing.Point(-1, 249);
            this.btnReactivar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(250, 109);
            this.btnReactivar.TabIndex = 40;
            this.btnReactivar.Text = "Dar de Alta";
            this.btnReactivar.UseVisualStyleBackColor = false;
            this.btnReactivar.Click += new System.EventHandler(this.btnReactivar_Click);
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.menuAdmin.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuAdmin.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(1590, 42);
            this.menuAdmin.TabIndex = 41;
            this.menuAdmin.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuAgregar,
            this.TsMenuSalir,
            this.TsMenucerrarApp});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(134, 38);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // TsMenuAgregar
            // 
            this.TsMenuAgregar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuAgregarArt,
            this.TsMenuAgregarMarca,
            this.TsMenuAgregarCat});
            this.TsMenuAgregar.Name = "TsMenuAgregar";
            this.TsMenuAgregar.Size = new System.Drawing.Size(389, 44);
            this.TsMenuAgregar.Text = "&Agregar....";
            // 
            // TsMenuAgregarArt
            // 
            this.TsMenuAgregarArt.Name = "TsMenuAgregarArt";
            this.TsMenuAgregarArt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TsMenuAgregarArt.Size = new System.Drawing.Size(359, 44);
            this.TsMenuAgregarArt.Text = "Artículo";
            this.TsMenuAgregarArt.Click += new System.EventHandler(this.TsMenuAgregarArticulo_Click);
            // 
            // TsMenuAgregarMarca
            // 
            this.TsMenuAgregarMarca.Name = "TsMenuAgregarMarca";
            this.TsMenuAgregarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.TsMenuAgregarMarca.Size = new System.Drawing.Size(359, 44);
            this.TsMenuAgregarMarca.Text = "Marca";
            this.TsMenuAgregarMarca.Click += new System.EventHandler(this.TsMenuAgregarMarca_Click);
            // 
            // TsMenuAgregarCat
            // 
            this.TsMenuAgregarCat.Name = "TsMenuAgregarCat";
            this.TsMenuAgregarCat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TsMenuAgregarCat.Size = new System.Drawing.Size(359, 44);
            this.TsMenuAgregarCat.Text = "Categoría";
            this.TsMenuAgregarCat.Click += new System.EventHandler(this.TsMenuAgregarCat_Click);
            // 
            // TsMenuSalir
            // 
            this.TsMenuSalir.Name = "TsMenuSalir";
            this.TsMenuSalir.Padding = new System.Windows.Forms.Padding(0);
            this.TsMenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TsMenuSalir.Size = new System.Drawing.Size(389, 40);
            this.TsMenuSalir.Text = "&Salir del Admin";
            this.TsMenuSalir.Click += new System.EventHandler(this.TsMenuSalir_Click);
            // 
            // TsMenucerrarApp
            // 
            this.TsMenucerrarApp.Name = "TsMenucerrarApp";
            this.TsMenucerrarApp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsMenucerrarApp.Size = new System.Drawing.Size(389, 44);
            this.TsMenucerrarApp.Text = "&Cerrar App";
            this.TsMenucerrarApp.Click += new System.EventHandler(this.TsMenuCerrar_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuCreador});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(68, 38);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // TsMenuCreador
            // 
            this.TsMenuCreador.Name = "TsMenuCreador";
            this.TsMenuCreador.Size = new System.Drawing.Size(348, 44);
            this.TsMenuCreador.Text = "Acerca del Creador";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnReactivar);
            this.panel1.Controls.Add(this.btnBaja);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 1010);
            this.panel1.TabIndex = 42;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregar.Location = new System.Drawing.Point(-1, 46);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 109);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pboxArticulo
            // 
            this.pboxArticulo.Location = new System.Drawing.Point(352, 477);
            this.pboxArticulo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pboxArticulo.Name = "pboxArticulo";
            this.pboxArticulo.Size = new System.Drawing.Size(541, 556);
            this.pboxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxArticulo.TabIndex = 1;
            this.pboxArticulo.TabStop = false;
            // 
            // FrmArticulos
            // 
            this.AccessibleDescription = "Formulario de artículos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1590, 1057);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescPrecio);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblDescNombre);
            this.Controls.Add(this.panelFiltroAv);
            this.Controls.Add(this.txtboxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pboxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "FrmArticulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelFiltroAv.ResumeLayout(false);
            this.panelFiltroAv.PerformLayout();
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulo)).EndInit();
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
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnReactivar;
        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsMenuAgregar;
        private System.Windows.Forms.ToolStripMenuItem TsMenuAgregarArt;
        private System.Windows.Forms.ToolStripMenuItem TsMenuAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem TsMenuAgregarCat;
        private System.Windows.Forms.ToolStripMenuItem TsMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsMenuCreador;
        private System.Windows.Forms.ToolStripMenuItem TsMenucerrarApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearFilter;
    }
}

