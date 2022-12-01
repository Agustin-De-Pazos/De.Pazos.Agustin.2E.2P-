namespace Forms
{
    partial class AsignarProfesorMateriaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarProfesorMateriaAdmin));
            this.btn_altaProfesorMat = new System.Windows.Forms.Button();
            this.lbl_profesorAltaMateria = new System.Windows.Forms.Label();
            this.lbl_profesorAlta = new System.Windows.Forms.Label();
            this.cmb_profesorAltaMateria = new System.Windows.Forms.ComboBox();
            this.cmb_profesorAlta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_altaProfesorMat
            // 
            this.btn_altaProfesorMat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_altaProfesorMat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_altaProfesorMat.Location = new System.Drawing.Point(70, 245);
            this.btn_altaProfesorMat.Name = "btn_altaProfesorMat";
            this.btn_altaProfesorMat.Size = new System.Drawing.Size(261, 79);
            this.btn_altaProfesorMat.TabIndex = 22;
            this.btn_altaProfesorMat.Text = "Asignar profesor a materia";
            this.btn_altaProfesorMat.UseVisualStyleBackColor = true;
            this.btn_altaProfesorMat.Click += new System.EventHandler(this.btn_altaProfesorMat_Click_1);
            // 
            // lbl_profesorAltaMateria
            // 
            this.lbl_profesorAltaMateria.AutoSize = true;
            this.lbl_profesorAltaMateria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesorAltaMateria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_profesorAltaMateria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_profesorAltaMateria.Location = new System.Drawing.Point(46, 141);
            this.lbl_profesorAltaMateria.Name = "lbl_profesorAltaMateria";
            this.lbl_profesorAltaMateria.Size = new System.Drawing.Size(104, 25);
            this.lbl_profesorAltaMateria.TabIndex = 21;
            this.lbl_profesorAltaMateria.Text = "Materia:";
            // 
            // lbl_profesorAlta
            // 
            this.lbl_profesorAlta.AutoSize = true;
            this.lbl_profesorAlta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesorAlta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_profesorAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_profesorAlta.Location = new System.Drawing.Point(46, 61);
            this.lbl_profesorAlta.Name = "lbl_profesorAlta";
            this.lbl_profesorAlta.Size = new System.Drawing.Size(116, 25);
            this.lbl_profesorAlta.TabIndex = 20;
            this.lbl_profesorAlta.Text = "Profesor:";
            // 
            // cmb_profesorAltaMateria
            // 
            this.cmb_profesorAltaMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_profesorAltaMateria.FormattingEnabled = true;
            this.cmb_profesorAltaMateria.Location = new System.Drawing.Point(199, 143);
            this.cmb_profesorAltaMateria.Name = "cmb_profesorAltaMateria";
            this.cmb_profesorAltaMateria.Size = new System.Drawing.Size(151, 28);
            this.cmb_profesorAltaMateria.TabIndex = 19;
            // 
            // cmb_profesorAlta
            // 
            this.cmb_profesorAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_profesorAlta.FormattingEnabled = true;
            this.cmb_profesorAlta.Location = new System.Drawing.Point(199, 61);
            this.cmb_profesorAlta.Name = "cmb_profesorAlta";
            this.cmb_profesorAlta.Size = new System.Drawing.Size(151, 28);
            this.cmb_profesorAlta.TabIndex = 18;
            // 
            // AsignarProfesorMateriaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 393);
            this.Controls.Add(this.btn_altaProfesorMat);
            this.Controls.Add(this.lbl_profesorAltaMateria);
            this.Controls.Add(this.lbl_profesorAlta);
            this.Controls.Add(this.cmb_profesorAltaMateria);
            this.Controls.Add(this.cmb_profesorAlta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarProfesorMateriaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Profesor a una Materia";
            this.Load += new System.EventHandler(this.AsignarProfesorMateriaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaProfesorMat;
        private System.Windows.Forms.Label lbl_profesorAltaMateria;
        private System.Windows.Forms.Label lbl_profesorAlta;
        private System.Windows.Forms.ComboBox cmb_profesorAltaMateria;
        private System.Windows.Forms.ComboBox cmb_profesorAlta;
    }
}