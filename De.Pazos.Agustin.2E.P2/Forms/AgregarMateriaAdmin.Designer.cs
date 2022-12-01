namespace Forms
{
    partial class AgregarMateriaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMateriaAdmin));
            this.cmb_altaCuatrimestre = new System.Windows.Forms.ComboBox();
            this.btn_agregarMateria = new System.Windows.Forms.Button();
            this.txt_materiaAlta = new System.Windows.Forms.TextBox();
            this.lbl_cuatrimestreAlta = new System.Windows.Forms.Label();
            this.lbl_materiasAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_altaCuatrimestre
            // 
            this.cmb_altaCuatrimestre.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_altaCuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_altaCuatrimestre.FormattingEnabled = true;
            this.cmb_altaCuatrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.cmb_altaCuatrimestre.Location = new System.Drawing.Point(235, 168);
            this.cmb_altaCuatrimestre.Name = "cmb_altaCuatrimestre";
            this.cmb_altaCuatrimestre.Size = new System.Drawing.Size(151, 28);
            this.cmb_altaCuatrimestre.TabIndex = 23;
            // 
            // btn_agregarMateria
            // 
            this.btn_agregarMateria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarMateria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_agregarMateria.Location = new System.Drawing.Point(73, 243);
            this.btn_agregarMateria.Name = "btn_agregarMateria";
            this.btn_agregarMateria.Size = new System.Drawing.Size(302, 79);
            this.btn_agregarMateria.TabIndex = 22;
            this.btn_agregarMateria.Text = "Agregar materia";
            this.btn_agregarMateria.UseVisualStyleBackColor = true;
            this.btn_agregarMateria.Click += new System.EventHandler(this.btn_agregarMateria_Click);
            // 
            // txt_materiaAlta
            // 
            this.txt_materiaAlta.Location = new System.Drawing.Point(235, 68);
            this.txt_materiaAlta.Name = "txt_materiaAlta";
            this.txt_materiaAlta.Size = new System.Drawing.Size(151, 27);
            this.txt_materiaAlta.TabIndex = 21;
            // 
            // lbl_cuatrimestreAlta
            // 
            this.lbl_cuatrimestreAlta.AutoSize = true;
            this.lbl_cuatrimestreAlta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cuatrimestreAlta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuatrimestreAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cuatrimestreAlta.Location = new System.Drawing.Point(49, 166);
            this.lbl_cuatrimestreAlta.Name = "lbl_cuatrimestreAlta";
            this.lbl_cuatrimestreAlta.Size = new System.Drawing.Size(165, 25);
            this.lbl_cuatrimestreAlta.TabIndex = 20;
            this.lbl_cuatrimestreAlta.Text = "Cuatrimestre:";
            // 
            // lbl_materiasAlta
            // 
            this.lbl_materiasAlta.AutoSize = true;
            this.lbl_materiasAlta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materiasAlta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiasAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_materiasAlta.Location = new System.Drawing.Point(12, 66);
            this.lbl_materiasAlta.Name = "lbl_materiasAlta";
            this.lbl_materiasAlta.Size = new System.Drawing.Size(202, 25);
            this.lbl_materiasAlta.TabIndex = 19;
            this.lbl_materiasAlta.Text = "Nombre materia:";
            // 
            // AgregarMateriaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 360);
            this.Controls.Add(this.cmb_altaCuatrimestre);
            this.Controls.Add(this.btn_agregarMateria);
            this.Controls.Add(this.txt_materiaAlta);
            this.Controls.Add(this.lbl_cuatrimestreAlta);
            this.Controls.Add(this.lbl_materiasAlta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarMateriaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Materia";
            this.Load += new System.EventHandler(this.AgregarMateriaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_altaCuatrimestre;
        private System.Windows.Forms.Button btn_agregarMateria;
        private System.Windows.Forms.TextBox txt_materiaAlta;
        private System.Windows.Forms.Label lbl_cuatrimestreAlta;
        private System.Windows.Forms.Label lbl_materiasAlta;
    }
}