namespace Forms
{
    partial class MenuProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProfesor));
            this.dgv_Profesor = new System.Windows.Forms.DataGridView();
            this.btn_NotaExamen = new System.Windows.Forms.Button();
            this.btn_crearExamen = new System.Windows.Forms.Button();
            this.btn_examen = new System.Windows.Forms.Button();
            this.btn_materias = new System.Windows.Forms.Button();
            this.bnt_alumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profesor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Profesor
            // 
            this.dgv_Profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Profesor.Location = new System.Drawing.Point(23, 32);
            this.dgv_Profesor.Name = "dgv_Profesor";
            this.dgv_Profesor.RowHeadersWidth = 51;
            this.dgv_Profesor.RowTemplate.Height = 29;
            this.dgv_Profesor.Size = new System.Drawing.Size(701, 409);
            this.dgv_Profesor.TabIndex = 5;
            // 
            // btn_NotaExamen
            // 
            this.btn_NotaExamen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NotaExamen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_NotaExamen.Location = new System.Drawing.Point(773, 269);
            this.btn_NotaExamen.Name = "btn_NotaExamen";
            this.btn_NotaExamen.Size = new System.Drawing.Size(154, 76);
            this.btn_NotaExamen.TabIndex = 7;
            this.btn_NotaExamen.Text = "Evaluar";
            this.btn_NotaExamen.UseVisualStyleBackColor = true;
            this.btn_NotaExamen.Click += new System.EventHandler(this.btn_NotaExamen_Click);
            // 
            // btn_crearExamen
            // 
            this.btn_crearExamen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_crearExamen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_crearExamen.Location = new System.Drawing.Point(773, 184);
            this.btn_crearExamen.Name = "btn_crearExamen";
            this.btn_crearExamen.Size = new System.Drawing.Size(154, 79);
            this.btn_crearExamen.TabIndex = 8;
            this.btn_crearExamen.Text = "Crear examen";
            this.btn_crearExamen.UseVisualStyleBackColor = true;
            this.btn_crearExamen.Click += new System.EventHandler(this.btn_crearExamen_Click);
            // 
            // btn_examen
            // 
            this.btn_examen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_examen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_examen.Location = new System.Drawing.Point(773, 367);
            this.btn_examen.Name = "btn_examen";
            this.btn_examen.Size = new System.Drawing.Size(154, 74);
            this.btn_examen.TabIndex = 9;
            this.btn_examen.Text = "Ver Examenes";
            this.btn_examen.UseVisualStyleBackColor = true;
            this.btn_examen.Click += new System.EventHandler(this.btn_examen_Click);
            // 
            // btn_materias
            // 
            this.btn_materias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_materias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_materias.Location = new System.Drawing.Point(773, 105);
            this.btn_materias.Name = "btn_materias";
            this.btn_materias.Size = new System.Drawing.Size(154, 63);
            this.btn_materias.TabIndex = 10;
            this.btn_materias.Text = "Materias Profesor";
            this.btn_materias.UseVisualStyleBackColor = true;
            this.btn_materias.Click += new System.EventHandler(this.btn_materias_Click);
            // 
            // bnt_alumnos
            // 
            this.bnt_alumnos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt_alumnos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bnt_alumnos.Location = new System.Drawing.Point(773, 32);
            this.bnt_alumnos.Name = "bnt_alumnos";
            this.bnt_alumnos.Size = new System.Drawing.Size(154, 65);
            this.bnt_alumnos.TabIndex = 11;
            this.bnt_alumnos.Text = "Ver Alumnos";
            this.bnt_alumnos.UseVisualStyleBackColor = true;
            this.bnt_alumnos.Click += new System.EventHandler(this.bnt_alumnos_Click);
            // 
            // MenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 474);
            this.Controls.Add(this.bnt_alumnos);
            this.Controls.Add(this.btn_materias);
            this.Controls.Add(this.btn_examen);
            this.Controls.Add(this.btn_crearExamen);
            this.Controls.Add(this.btn_NotaExamen);
            this.Controls.Add(this.dgv_Profesor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Profesor";
            this.Load += new System.EventHandler(this.MenuProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Profesor;
        private System.Windows.Forms.Button btn_NotaExamen;
        private System.Windows.Forms.Button btn_crearExamen;
        private System.Windows.Forms.Button btn_examen;
        private System.Windows.Forms.Button btn_materias;
        private System.Windows.Forms.Button bnt_alumnos;
    }
}