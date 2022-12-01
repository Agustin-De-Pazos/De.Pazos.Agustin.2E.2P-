namespace Forms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_inicioSesion = new System.Windows.Forms.Label();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.btn_adminH = new System.Windows.Forms.Button();
            this.btn_profesorH = new System.Windows.Forms.Button();
            this.btn_alumnoH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(144, 100);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Email *";
            this.txt_usuario.Size = new System.Drawing.Size(242, 34);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Tag = "";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña.Location = new System.Drawing.Point(144, 174);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PlaceholderText = "Contraseña *";
            this.txt_contraseña.Size = new System.Drawing.Size(242, 34);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.Tag = "";
            // 
            // lbl_inicioSesion
            // 
            this.lbl_inicioSesion.AutoSize = true;
            this.lbl_inicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inicioSesion.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_inicioSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_inicioSesion.Location = new System.Drawing.Point(144, 24);
            this.lbl_inicioSesion.Name = "lbl_inicioSesion";
            this.lbl_inicioSesion.Size = new System.Drawing.Size(226, 29);
            this.lbl_inicioSesion.TabIndex = 4;
            this.lbl_inicioSesion.Text = "Inicio de Sesion";
            // 
            // btn_logIn
            // 
            this.btn_logIn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_logIn.Location = new System.Drawing.Point(144, 257);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(242, 60);
            this.btn_logIn.TabIndex = 1;
            this.btn_logIn.Text = "Aceptar";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // btn_adminH
            // 
            this.btn_adminH.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adminH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_adminH.Location = new System.Drawing.Point(12, 349);
            this.btn_adminH.Name = "btn_adminH";
            this.btn_adminH.Size = new System.Drawing.Size(154, 63);
            this.btn_adminH.TabIndex = 6;
            this.btn_adminH.Text = "Admin harcodeado";
            this.btn_adminH.UseVisualStyleBackColor = true;
            this.btn_adminH.Click += new System.EventHandler(this.btn_adminH_Click);
            // 
            // btn_profesorH
            // 
            this.btn_profesorH.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_profesorH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_profesorH.Location = new System.Drawing.Point(172, 349);
            this.btn_profesorH.Name = "btn_profesorH";
            this.btn_profesorH.Size = new System.Drawing.Size(167, 63);
            this.btn_profesorH.TabIndex = 7;
            this.btn_profesorH.Text = "Profesor harcodeado";
            this.btn_profesorH.UseVisualStyleBackColor = true;
            this.btn_profesorH.Click += new System.EventHandler(this.btn_profesorH_Click);
            // 
            // btn_alumnoH
            // 
            this.btn_alumnoH.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alumnoH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_alumnoH.Location = new System.Drawing.Point(344, 349);
            this.btn_alumnoH.Name = "btn_alumnoH";
            this.btn_alumnoH.Size = new System.Drawing.Size(167, 63);
            this.btn_alumnoH.TabIndex = 8;
            this.btn_alumnoH.Text = "Alumno harcodeado";
            this.btn_alumnoH.UseVisualStyleBackColor = true;
            this.btn_alumnoH.Click += new System.EventHandler(this.btn_alumnoH_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 439);
            this.Controls.Add(this.btn_alumnoH);
            this.Controls.Add(this.btn_profesorH);
            this.Controls.Add(this.btn_adminH);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.lbl_inicioSesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_inicioSesion;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Button btn_adminH;
        private System.Windows.Forms.Button btn_profesorH;
        private System.Windows.Forms.Button btn_alumnoH;
    }
}