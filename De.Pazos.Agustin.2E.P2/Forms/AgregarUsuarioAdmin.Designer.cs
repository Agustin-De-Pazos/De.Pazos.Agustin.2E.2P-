namespace Forms
{
    partial class AgregarUsuarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuarioAdmin));
            this.lbl_altaDni = new System.Windows.Forms.Label();
            this.txt_altaDni = new System.Windows.Forms.TextBox();
            this.lbl_altaGmail = new System.Windows.Forms.Label();
            this.txt_altaNombre = new System.Windows.Forms.TextBox();
            this.txt_altaApellido = new System.Windows.Forms.TextBox();
            this.txt_apellidoAlta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_usuarioALTA = new System.Windows.Forms.ComboBox();
            this.txt_contraseñaAtla = new System.Windows.Forms.TextBox();
            this.txt_GmailAlta = new System.Windows.Forms.TextBox();
            this.lbl_altaNombre = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_altaDni
            // 
            this.lbl_altaDni.AutoSize = true;
            this.lbl_altaDni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altaDni.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_altaDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_altaDni.Location = new System.Drawing.Point(420, 37);
            this.lbl_altaDni.Name = "lbl_altaDni";
            this.lbl_altaDni.Size = new System.Drawing.Size(46, 20);
            this.lbl_altaDni.TabIndex = 38;
            this.lbl_altaDni.Text = "DNI";
            // 
            // txt_altaDni
            // 
            this.txt_altaDni.Location = new System.Drawing.Point(555, 35);
            this.txt_altaDni.Name = "txt_altaDni";
            this.txt_altaDni.Size = new System.Drawing.Size(196, 27);
            this.txt_altaDni.TabIndex = 37;
            // 
            // lbl_altaGmail
            // 
            this.lbl_altaGmail.AutoSize = true;
            this.lbl_altaGmail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altaGmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_altaGmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_altaGmail.Location = new System.Drawing.Point(420, 188);
            this.lbl_altaGmail.Name = "lbl_altaGmail";
            this.lbl_altaGmail.Size = new System.Drawing.Size(64, 20);
            this.lbl_altaGmail.TabIndex = 36;
            this.lbl_altaGmail.Text = "Gmail";
            // 
            // txt_altaNombre
            // 
            this.txt_altaNombre.Location = new System.Drawing.Point(189, 38);
            this.txt_altaNombre.Name = "txt_altaNombre";
            this.txt_altaNombre.Size = new System.Drawing.Size(181, 27);
            this.txt_altaNombre.TabIndex = 35;
            // 
            // txt_altaApellido
            // 
            this.txt_altaApellido.Location = new System.Drawing.Point(189, 117);
            this.txt_altaApellido.Name = "txt_altaApellido";
            this.txt_altaApellido.Size = new System.Drawing.Size(181, 27);
            this.txt_altaApellido.TabIndex = 34;
            // 
            // txt_apellidoAlta
            // 
            this.txt_apellidoAlta.AutoSize = true;
            this.txt_apellidoAlta.BackColor = System.Drawing.Color.Transparent;
            this.txt_apellidoAlta.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_apellidoAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_apellidoAlta.Location = new System.Drawing.Point(38, 117);
            this.txt_apellidoAlta.Name = "txt_apellidoAlta";
            this.txt_apellidoAlta.Size = new System.Drawing.Size(87, 20);
            this.txt_apellidoAlta.TabIndex = 33;
            this.txt_apellidoAlta.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tipo de usuario";
            // 
            // cmb_usuarioALTA
            // 
            this.cmb_usuarioALTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_usuarioALTA.FormattingEnabled = true;
            this.cmb_usuarioALTA.Items.AddRange(new object[] {
            "Admin",
            "Alumno",
            "Profesor"});
            this.cmb_usuarioALTA.Location = new System.Drawing.Point(189, 186);
            this.cmb_usuarioALTA.Name = "cmb_usuarioALTA";
            this.cmb_usuarioALTA.Size = new System.Drawing.Size(181, 28);
            this.cmb_usuarioALTA.TabIndex = 31;
            // 
            // txt_contraseñaAtla
            // 
            this.txt_contraseñaAtla.Location = new System.Drawing.Point(555, 110);
            this.txt_contraseñaAtla.Name = "txt_contraseñaAtla";
            this.txt_contraseñaAtla.Size = new System.Drawing.Size(196, 27);
            this.txt_contraseñaAtla.TabIndex = 30;
            // 
            // txt_GmailAlta
            // 
            this.txt_GmailAlta.Location = new System.Drawing.Point(555, 186);
            this.txt_GmailAlta.Name = "txt_GmailAlta";
            this.txt_GmailAlta.Size = new System.Drawing.Size(196, 27);
            this.txt_GmailAlta.TabIndex = 29;
            // 
            // lbl_altaNombre
            // 
            this.lbl_altaNombre.AutoSize = true;
            this.lbl_altaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_altaNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_altaNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_altaNombre.Location = new System.Drawing.Point(38, 35);
            this.lbl_altaNombre.Name = "lbl_altaNombre";
            this.lbl_altaNombre.Size = new System.Drawing.Size(84, 20);
            this.lbl_altaNombre.TabIndex = 28;
            this.lbl_altaNombre.Text = "Nombre";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_contraseña.Location = new System.Drawing.Point(420, 117);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(116, 20);
            this.lbl_contraseña.TabIndex = 27;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // btn_alta
            // 
            this.btn_alta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_alta.Location = new System.Drawing.Point(271, 326);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(226, 84);
            this.btn_alta.TabIndex = 26;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // AgregarUsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_altaDni);
            this.Controls.Add(this.txt_altaDni);
            this.Controls.Add(this.lbl_altaGmail);
            this.Controls.Add(this.txt_altaNombre);
            this.Controls.Add(this.txt_altaApellido);
            this.Controls.Add(this.txt_apellidoAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_usuarioALTA);
            this.Controls.Add(this.txt_contraseñaAtla);
            this.Controls.Add(this.txt_GmailAlta);
            this.Controls.Add(this.lbl_altaNombre);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.btn_alta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuarioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.AgregarUsuarioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_altaDni;
        private System.Windows.Forms.TextBox txt_altaDni;
        private System.Windows.Forms.Label lbl_altaGmail;
        private System.Windows.Forms.TextBox txt_altaNombre;
        private System.Windows.Forms.TextBox txt_altaApellido;
        private System.Windows.Forms.Label txt_apellidoAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_usuarioALTA;
        private System.Windows.Forms.TextBox txt_contraseñaAtla;
        private System.Windows.Forms.TextBox txt_GmailAlta;
        private System.Windows.Forms.Label lbl_altaNombre;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Button btn_alta;
    }
}