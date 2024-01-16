namespace WinForm_App
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAutorNombre = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.pboxMail = new System.Windows.Forms.PictureBox();
            this.pboxPorfolio = new System.Windows.Forms.PictureBox();
            this.pboxGithub = new System.Windows.Forms.PictureBox();
            this.pboxLinkedin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPorfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLinkedin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(180, 88);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(144, 38);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autora:";
            // 
            // lblAutorNombre
            // 
            this.lblAutorNombre.AutoSize = true;
            this.lblAutorNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.lblAutorNombre.Location = new System.Drawing.Point(391, 88);
            this.lblAutorNombre.Name = "lblAutorNombre";
            this.lblAutorNombre.Size = new System.Drawing.Size(224, 38);
            this.lblAutorNombre.TabIndex = 4;
            this.lblAutorNombre.Text = "Analía Leyez";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(180, 193);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(474, 38);
            this.lblContacto.TabIndex = 5;
            this.lblContacto.Text = "Contacto y otros proyectos:";
            // 
            // pboxMail
            // 
            this.pboxMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxMail.Image = global::WinForm_App.Properties.Resources.mail_64px;
            this.pboxMail.Location = new System.Drawing.Point(596, 275);
            this.pboxMail.Name = "pboxMail";
            this.pboxMail.Size = new System.Drawing.Size(117, 96);
            this.pboxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMail.TabIndex = 6;
            this.pboxMail.TabStop = false;
            this.pboxMail.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pboxPorfolio
            // 
            this.pboxPorfolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxPorfolio.Image = global::WinForm_App.Properties.Resources.perfil_64px;
            this.pboxPorfolio.Location = new System.Drawing.Point(428, 275);
            this.pboxPorfolio.Name = "pboxPorfolio";
            this.pboxPorfolio.Size = new System.Drawing.Size(117, 96);
            this.pboxPorfolio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxPorfolio.TabIndex = 2;
            this.pboxPorfolio.TabStop = false;
            this.pboxPorfolio.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pboxGithub
            // 
            this.pboxGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxGithub.Image = global::WinForm_App.Properties.Resources.github_64px;
            this.pboxGithub.Location = new System.Drawing.Point(250, 275);
            this.pboxGithub.Name = "pboxGithub";
            this.pboxGithub.Size = new System.Drawing.Size(117, 96);
            this.pboxGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxGithub.TabIndex = 1;
            this.pboxGithub.TabStop = false;
            this.pboxGithub.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pboxLinkedin
            // 
            this.pboxLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxLinkedin.Image = global::WinForm_App.Properties.Resources.linkedin_64px;
            this.pboxLinkedin.Location = new System.Drawing.Point(80, 275);
            this.pboxLinkedin.Name = "pboxLinkedin";
            this.pboxLinkedin.Size = new System.Drawing.Size(117, 96);
            this.pboxLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLinkedin.TabIndex = 0;
            this.pboxLinkedin.TabStop = false;
            this.pboxLinkedin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 412);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 14, 4);
            this.label1.Size = new System.Drawing.Size(856, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proyecto realizado para el curso Nivel 2 de C# [.Net+SQL] de MaxiPrograma";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(855, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxMail);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblAutorNombre);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.pboxPorfolio);
            this.Controls.Add(this.pboxGithub);
            this.Controls.Add(this.pboxLinkedin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPorfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLinkedin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLinkedin;
        private System.Windows.Forms.PictureBox pboxGithub;
        private System.Windows.Forms.PictureBox pboxPorfolio;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAutorNombre;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.PictureBox pboxMail;
        private System.Windows.Forms.Label label1;
    }
}