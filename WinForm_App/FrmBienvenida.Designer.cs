namespace WinForm_App
{
    partial class FrmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pboxHome = new System.Windows.Forms.PictureBox();
            this.statusStripHome = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHome)).BeginInit();
            this.statusStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(68, 102);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(968, 55);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al Administrador de Robotin!";
            // 
            // pboxHome
            // 
            this.pboxHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxHome.Image = global::WinForm_App.Properties.Resources.imgHome;
            this.pboxHome.InitialImage = null;
            this.pboxHome.Location = new System.Drawing.Point(323, 102);
            this.pboxHome.Name = "pboxHome";
            this.pboxHome.Size = new System.Drawing.Size(341, 334);
            this.pboxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHome.TabIndex = 1;
            this.pboxHome.TabStop = false;
            this.pboxHome.Click += new System.EventHandler(this.pboxHome_Click);
            // 
            // statusStripHome
            // 
            this.statusStripHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.statusStripHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripHome.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripHome.Location = new System.Drawing.Point(0, 553);
            this.statusStripHome.Name = "statusStripHome";
            this.statusStripHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripHome.Size = new System.Drawing.Size(1078, 42);
            this.statusStripHome.SizingGrip = false;
            this.statusStripHome.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(382, 32);
            this.toolStripStatusLabel1.Text = "Creado por Analía Leyez (2024) ©";
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1078, 595);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.statusStripHome);
            this.Controls.Add(this.pboxHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1104, 666);
            this.MinimumSize = new System.Drawing.Size(1104, 666);
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pboxHome)).EndInit();
            this.statusStripHome.ResumeLayout(false);
            this.statusStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pboxHome;
        private System.Windows.Forms.StatusStrip statusStripHome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}