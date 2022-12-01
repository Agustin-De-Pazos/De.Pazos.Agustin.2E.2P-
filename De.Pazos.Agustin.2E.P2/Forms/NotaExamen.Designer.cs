namespace Forms
{
    partial class NotaExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaExamen));
            this.lbl_alumnos = new System.Windows.Forms.Label();
            this.cmb_alumnos = new System.Windows.Forms.ComboBox();
            this.lbl_materiaNombre = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.btn_SubirNota = new System.Windows.Forms.Button();
            this.cmb_notaPrimerParcial = new System.Windows.Forms.ComboBox();
            this.cmb_notaSegundoParcial = new System.Windows.Forms.ComboBox();
            this.lbl_notaPrimerParcial = new System.Windows.Forms.Label();
            this.lbl_notaSegundoParcial = new System.Windows.Forms.Label();
            this.lbl_hayAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_alumnos
            // 
            this.lbl_alumnos.AutoSize = true;
            this.lbl_alumnos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alumnos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alumnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_alumnos.Location = new System.Drawing.Point(159, 126);
            this.lbl_alumnos.Name = "lbl_alumnos";
            this.lbl_alumnos.Size = new System.Drawing.Size(106, 25);
            this.lbl_alumnos.TabIndex = 14;
            this.lbl_alumnos.Text = "Alumno:";
            // 
            // cmb_alumnos
            // 
            this.cmb_alumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_alumnos.FormattingEnabled = true;
            this.cmb_alumnos.Location = new System.Drawing.Point(313, 121);
            this.cmb_alumnos.Name = "cmb_alumnos";
            this.cmb_alumnos.Size = new System.Drawing.Size(151, 28);
            this.cmb_alumnos.TabIndex = 13;
            // 
            // lbl_materiaNombre
            // 
            this.lbl_materiaNombre.AutoSize = true;
            this.lbl_materiaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materiaNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiaNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_materiaNombre.Location = new System.Drawing.Point(149, 49);
            this.lbl_materiaNombre.Name = "lbl_materiaNombre";
            this.lbl_materiaNombre.Size = new System.Drawing.Size(116, 25);
            this.lbl_materiaNombre.TabIndex = 12;
            this.lbl_materiaNombre.Text = "Materias:";
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(313, 46);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(151, 28);
            this.cmb_materia.TabIndex = 11;
            this.cmb_materia.SelectedIndexChanged += new System.EventHandler(this.cmb_materia_SelectedIndexChanged);
            // 
            // btn_SubirNota
            // 
            this.btn_SubirNota.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SubirNota.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_SubirNota.Location = new System.Drawing.Point(539, 126);
            this.btn_SubirNota.Name = "btn_SubirNota";
            this.btn_SubirNota.Size = new System.Drawing.Size(181, 112);
            this.btn_SubirNota.TabIndex = 15;
            this.btn_SubirNota.Text = "Subir nota de alumno";
            this.btn_SubirNota.UseVisualStyleBackColor = true;
            this.btn_SubirNota.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_notaPrimerParcial
            // 
            this.cmb_notaPrimerParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_notaPrimerParcial.FormattingEnabled = true;
            this.cmb_notaPrimerParcial.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_notaPrimerParcial.Location = new System.Drawing.Point(313, 210);
            this.cmb_notaPrimerParcial.Name = "cmb_notaPrimerParcial";
            this.cmb_notaPrimerParcial.Size = new System.Drawing.Size(151, 28);
            this.cmb_notaPrimerParcial.TabIndex = 16;
            // 
            // cmb_notaSegundoParcial
            // 
            this.cmb_notaSegundoParcial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_notaSegundoParcial.FormattingEnabled = true;
            this.cmb_notaSegundoParcial.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_notaSegundoParcial.Location = new System.Drawing.Point(313, 304);
            this.cmb_notaSegundoParcial.Name = "cmb_notaSegundoParcial";
            this.cmb_notaSegundoParcial.Size = new System.Drawing.Size(151, 28);
            this.cmb_notaSegundoParcial.TabIndex = 17;
            // 
            // lbl_notaPrimerParcial
            // 
            this.lbl_notaPrimerParcial.AutoSize = true;
            this.lbl_notaPrimerParcial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notaPrimerParcial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_notaPrimerParcial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_notaPrimerParcial.Location = new System.Drawing.Point(33, 208);
            this.lbl_notaPrimerParcial.Name = "lbl_notaPrimerParcial";
            this.lbl_notaPrimerParcial.Size = new System.Drawing.Size(232, 25);
            this.lbl_notaPrimerParcial.TabIndex = 18;
            this.lbl_notaPrimerParcial.Text = "Nota Primer Parcial";
            // 
            // lbl_notaSegundoParcial
            // 
            this.lbl_notaSegundoParcial.AutoSize = true;
            this.lbl_notaSegundoParcial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notaSegundoParcial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_notaSegundoParcial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_notaSegundoParcial.Location = new System.Drawing.Point(12, 307);
            this.lbl_notaSegundoParcial.Name = "lbl_notaSegundoParcial";
            this.lbl_notaSegundoParcial.Size = new System.Drawing.Size(253, 25);
            this.lbl_notaSegundoParcial.TabIndex = 19;
            this.lbl_notaSegundoParcial.Text = "Nota Segundo Parcial";
            // 
            // lbl_hayAlumnos
            // 
            this.lbl_hayAlumnos.AutoSize = true;
            this.lbl_hayAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hayAlumnos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hayAlumnos.Location = new System.Drawing.Point(303, 129);
            this.lbl_hayAlumnos.Name = "lbl_hayAlumnos";
            this.lbl_hayAlumnos.Size = new System.Drawing.Size(135, 23);
            this.lbl_hayAlumnos.TabIndex = 20;
            this.lbl_hayAlumnos.Text = "No hay alumnos";
            this.lbl_hayAlumnos.Visible = false;
            // 
            // NotaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 396);
            this.Controls.Add(this.lbl_hayAlumnos);
            this.Controls.Add(this.lbl_notaSegundoParcial);
            this.Controls.Add(this.lbl_notaPrimerParcial);
            this.Controls.Add(this.cmb_notaSegundoParcial);
            this.Controls.Add(this.cmb_notaPrimerParcial);
            this.Controls.Add(this.btn_SubirNota);
            this.Controls.Add(this.lbl_alumnos);
            this.Controls.Add(this.cmb_alumnos);
            this.Controls.Add(this.lbl_materiaNombre);
            this.Controls.Add(this.cmb_materia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotaExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir Nota";
            this.Load += new System.EventHandler(this.NotaExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_alumnos;
        private System.Windows.Forms.ComboBox cmb_alumnos;
        private System.Windows.Forms.Label lbl_materiaNombre;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Button btn_SubirNota;
        private System.Windows.Forms.ComboBox cmb_notaPrimerParcial;
        private System.Windows.Forms.ComboBox cmb_notaSegundoParcial;
        private System.Windows.Forms.Label lbl_notaPrimerParcial;
        private System.Windows.Forms.Label lbl_notaSegundoParcial;
        private System.Windows.Forms.Label lbl_hayAlumnos;
    }
}