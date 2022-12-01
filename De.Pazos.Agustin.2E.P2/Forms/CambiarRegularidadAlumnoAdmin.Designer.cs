namespace Forms
{
    partial class CambiarRegularidadAlumnoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarRegularidadAlumnoAdmin));
            this.cmb_cambiarEstadoRyL = new System.Windows.Forms.ComboBox();
            this.lbl_alumnoElegir = new System.Windows.Forms.Label();
            this.btn_cambiarEstadoMateriaA = new System.Windows.Forms.Button();
            this.cmb_elegirAlumno = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.lbl_hayAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_cambiarEstadoRyL
            // 
            this.cmb_cambiarEstadoRyL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cambiarEstadoRyL.FormattingEnabled = true;
            this.cmb_cambiarEstadoRyL.Items.AddRange(new object[] {
            "Libre",
            "Regular"});
            this.cmb_cambiarEstadoRyL.Location = new System.Drawing.Point(259, 165);
            this.cmb_cambiarEstadoRyL.Name = "cmb_cambiarEstadoRyL";
            this.cmb_cambiarEstadoRyL.Size = new System.Drawing.Size(169, 26);
            this.cmb_cambiarEstadoRyL.TabIndex = 39;
            // 
            // lbl_alumnoElegir
            // 
            this.lbl_alumnoElegir.AutoSize = true;
            this.lbl_alumnoElegir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alumnoElegir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alumnoElegir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_alumnoElegir.Location = new System.Drawing.Point(46, 103);
            this.lbl_alumnoElegir.Name = "lbl_alumnoElegir";
            this.lbl_alumnoElegir.Size = new System.Drawing.Size(175, 25);
            this.lbl_alumnoElegir.TabIndex = 38;
            this.lbl_alumnoElegir.Text = "Elegir alumno:";
            // 
            // btn_cambiarEstadoMateriaA
            // 
            this.btn_cambiarEstadoMateriaA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarEstadoMateriaA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cambiarEstadoMateriaA.Location = new System.Drawing.Point(154, 264);
            this.btn_cambiarEstadoMateriaA.Name = "btn_cambiarEstadoMateriaA";
            this.btn_cambiarEstadoMateriaA.Size = new System.Drawing.Size(251, 68);
            this.btn_cambiarEstadoMateriaA.TabIndex = 37;
            this.btn_cambiarEstadoMateriaA.Text = "Confirmar cambio de estado";
            this.btn_cambiarEstadoMateriaA.UseVisualStyleBackColor = true;
            this.btn_cambiarEstadoMateriaA.Click += new System.EventHandler(this.btn_cambiarEstadoMateriaA_Click);
            // 
            // cmb_elegirAlumno
            // 
            this.cmb_elegirAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_elegirAlumno.FormattingEnabled = true;
            this.cmb_elegirAlumno.Location = new System.Drawing.Point(259, 97);
            this.cmb_elegirAlumno.Name = "cmb_elegirAlumno";
            this.cmb_elegirAlumno.Size = new System.Drawing.Size(169, 26);
            this.cmb_elegirAlumno.TabIndex = 36;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_estado.Location = new System.Drawing.Point(46, 165);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(199, 50);
            this.lbl_estado.TabIndex = 35;
            this.lbl_estado.Text = "Cambiar cursada\r\nAlumno";
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(259, 37);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(169, 26);
            this.cmb_materia.TabIndex = 34;
            this.cmb_materia.SelectedIndexChanged += new System.EventHandler(this.cmb_materia_SelectedIndexChanged);
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_materia.Location = new System.Drawing.Point(46, 38);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(104, 25);
            this.lbl_materia.TabIndex = 33;
            this.lbl_materia.Text = "Materia:";
            // 
            // lbl_hayAlumnos
            // 
            this.lbl_hayAlumnos.AutoSize = true;
            this.lbl_hayAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hayAlumnos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hayAlumnos.Location = new System.Drawing.Point(227, 103);
            this.lbl_hayAlumnos.Name = "lbl_hayAlumnos";
            this.lbl_hayAlumnos.Size = new System.Drawing.Size(307, 18);
            this.lbl_hayAlumnos.TabIndex = 40;
            this.lbl_hayAlumnos.Text = "No hay alumnos cursando dicha materia";
            // 
            // CambiarRegularidadAlumnoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.Controls.Add(this.lbl_hayAlumnos);
            this.Controls.Add(this.cmb_cambiarEstadoRyL);
            this.Controls.Add(this.lbl_alumnoElegir);
            this.Controls.Add(this.btn_cambiarEstadoMateriaA);
            this.Controls.Add(this.cmb_elegirAlumno);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.lbl_materia);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarRegularidadAlumnoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio De Estado Admin";
            this.Load += new System.EventHandler(this.CambiarRegularidadAlumnoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_cambiarEstadoRyL;
        private System.Windows.Forms.Label lbl_alumnoElegir;
        private System.Windows.Forms.Button btn_cambiarEstadoMateriaA;
        private System.Windows.Forms.ComboBox cmb_elegirAlumno;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.Label lbl_hayAlumnos;
    }
}