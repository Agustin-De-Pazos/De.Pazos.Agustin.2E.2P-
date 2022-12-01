namespace Forms
{
    partial class MenuAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlumno));
            this.btn_Inscribirse = new System.Windows.Forms.Button();
            this.dgv_alumno = new System.Windows.Forms.DataGridView();
            this.btn_asistencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inscribirse
            // 
            this.btn_Inscribirse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inscribirse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Inscribirse.Location = new System.Drawing.Point(793, 59);
            this.btn_Inscribirse.Name = "btn_Inscribirse";
            this.btn_Inscribirse.Size = new System.Drawing.Size(179, 62);
            this.btn_Inscribirse.TabIndex = 0;
            this.btn_Inscribirse.Text = "Inscripcion de materias";
            this.btn_Inscribirse.UseVisualStyleBackColor = true;
            this.btn_Inscribirse.Click += new System.EventHandler(this.btn_Inscribirse_Click);
            // 
            // dgv_alumno
            // 
            this.dgv_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumno.Location = new System.Drawing.Point(12, 12);
            this.dgv_alumno.Name = "dgv_alumno";
            this.dgv_alumno.RowHeadersWidth = 51;
            this.dgv_alumno.RowTemplate.Height = 29;
            this.dgv_alumno.Size = new System.Drawing.Size(757, 427);
            this.dgv_alumno.TabIndex = 2;
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_asistencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_asistencia.Location = new System.Drawing.Point(793, 342);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(179, 61);
            this.btn_asistencia.TabIndex = 7;
            this.btn_asistencia.Text = "Dar asistencia";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // MenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 465);
            this.Controls.Add(this.btn_asistencia);
            this.Controls.Add(this.dgv_alumno);
            this.Controls.Add(this.btn_Inscribirse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Alumno                                                                      " +
    "                                ";
            this.Load += new System.EventHandler(this.MenuAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Inscribirse;
        private System.Windows.Forms.DataGridView dgv_alumno;
        private System.Windows.Forms.Button btn_asistencia;
    }
}