namespace Forms
{
    partial class InscripcionAlumMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionAlumMaterias));
            this.lbl_inscripcion = new System.Windows.Forms.Label();
            this.cmb_materias = new System.Windows.Forms.ComboBox();
            this.btn_inscripcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inscripcion
            // 
            this.lbl_inscripcion.AutoSize = true;
            this.lbl_inscripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inscripcion.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_inscripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_inscripcion.Location = new System.Drawing.Point(110, 34);
            this.lbl_inscripcion.Name = "lbl_inscripcion";
            this.lbl_inscripcion.Size = new System.Drawing.Size(131, 26);
            this.lbl_inscripcion.TabIndex = 0;
            this.lbl_inscripcion.Text = "Inscripcion";
            // 
            // cmb_materias
            // 
            this.cmb_materias.FormattingEnabled = true;
            this.cmb_materias.Location = new System.Drawing.Point(101, 179);
            this.cmb_materias.Name = "cmb_materias";
            this.cmb_materias.Size = new System.Drawing.Size(149, 28);
            this.cmb_materias.TabIndex = 1;
            // 
            // btn_inscripcion
            // 
            this.btn_inscripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_inscripcion.Location = new System.Drawing.Point(101, 267);
            this.btn_inscripcion.Name = "btn_inscripcion";
            this.btn_inscripcion.Size = new System.Drawing.Size(149, 65);
            this.btn_inscripcion.TabIndex = 2;
            this.btn_inscripcion.Text = "Inscripcion de Materias";
            this.btn_inscripcion.UseVisualStyleBackColor = true;
            this.btn_inscripcion.Click += new System.EventHandler(this.btn_inscripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materias";
            // 
            // InscripcionAlumMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inscripcion);
            this.Controls.Add(this.cmb_materias);
            this.Controls.Add(this.lbl_inscripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscripcionAlumMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion materias";
            this.Load += new System.EventHandler(this.InscripcionAlumMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inscripcion;
        private System.Windows.Forms.ComboBox cmb_materias;
        private System.Windows.Forms.Button btn_inscripcion;
        private System.Windows.Forms.Label label1;
    }
}