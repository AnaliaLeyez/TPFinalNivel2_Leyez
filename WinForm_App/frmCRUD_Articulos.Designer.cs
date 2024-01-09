namespace WinForm_App
{
    partial class frmCRUD_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUD_Articulos));
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.pboxImg = new System.Windows.Forms.PictureBox();
            this.tbxUrlImg = new System.Windows.Forms.TextBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(443, 184);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(54, 39);
            this.btnAgregarImg.TabIndex = 31;
            this.btnAgregarImg.Text = "+";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            // 
            // pboxImg
            // 
            this.pboxImg.Location = new System.Drawing.Point(530, 43);
            this.pboxImg.Name = "pboxImg";
            this.pboxImg.Size = new System.Drawing.Size(346, 276);
            this.pboxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImg.TabIndex = 30;
            this.pboxImg.TabStop = false;
            // 
            // tbxUrlImg
            // 
            this.tbxUrlImg.Location = new System.Drawing.Point(163, 184);
            this.tbxUrlImg.Name = "tbxUrlImg";
            this.tbxUrlImg.Size = new System.Drawing.Size(274, 31);
            this.tbxUrlImg.TabIndex = 22;
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Location = new System.Drawing.Point(32, 190);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(115, 25);
            this.lblUrlImg.TabIndex = 29;
            this.lblUrlImg.Text = "Url Imagen";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(32, 294);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 240);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 25);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "Marca";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(163, 286);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(274, 33);
            this.cboxCategoria.TabIndex = 24;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(163, 232);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(274, 33);
            this.cboxMarca.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(306, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 49);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(37, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 49);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(163, 133);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(274, 31);
            this.tbxDescripcion.TabIndex = 20;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(163, 86);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(274, 31);
            this.tbxNombre.TabIndex = 18;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(163, 43);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(274, 31);
            this.tbxCodigo.TabIndex = 16;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 25);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(163, 345);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(274, 31);
            this.tbxPrecio.TabIndex = 32;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 345);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 25);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio";
            // 
            // frmCRUD_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 534);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.pboxImg);
            this.Controls.Add(this.tbxUrlImg);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCRUD_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm CRUD de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.PictureBox pboxImg;
        private System.Windows.Forms.TextBox tbxUrlImg;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}