namespace Forms
{
    partial class AsistenciaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaAlumno));
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(201, 77);
            this.cmb_materia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(206, 28);
            this.cmb_materia.TabIndex = 11;
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_asistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_asistencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_asistencia.Location = new System.Drawing.Point(62, 80);
            this.lbl_asistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(108, 25);
            this.lbl_asistencia.TabIndex = 10;
            this.lbl_asistencia.Text = "Materias";
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_asistencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_asistencia.Location = new System.Drawing.Point(62, 173);
            this.btn_asistencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(363, 72);
            this.btn_asistencia.TabIndex = 9;
            this.btn_asistencia.Text = "Asistencia";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // AsistenciaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 311);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.lbl_asistencia);
            this.Controls.Add(this.btn_asistencia);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AsistenciaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia Alumno";
            this.Load += new System.EventHandler(this.AsistenciaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.Button btn_asistencia;
    }
}