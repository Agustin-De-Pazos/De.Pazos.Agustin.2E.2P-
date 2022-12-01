namespace Forms
{
    partial class ExportarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportarAlumnos));
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_json = new System.Windows.Forms.Button();
            this.lbl_materias = new System.Windows.Forms.Label();
            this.cmb_materias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_csv
            // 
            this.btn_csv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_csv.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_csv.Location = new System.Drawing.Point(36, 236);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(154, 88);
            this.btn_csv.TabIndex = 0;
            this.btn_csv.Text = "Exportar CSV";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // btn_json
            // 
            this.btn_json.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_json.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_json.Location = new System.Drawing.Point(228, 236);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(154, 88);
            this.btn_json.TabIndex = 1;
            this.btn_json.Text = "Exportar JSON";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // lbl_materias
            // 
            this.lbl_materias.AutoSize = true;
            this.lbl_materias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materias.Location = new System.Drawing.Point(64, 115);
            this.lbl_materias.Name = "lbl_materias";
            this.lbl_materias.Size = new System.Drawing.Size(69, 20);
            this.lbl_materias.TabIndex = 2;
            this.lbl_materias.Text = "Materias:";
            // 
            // cmb_materias
            // 
            this.cmb_materias.FormattingEnabled = true;
            this.cmb_materias.Location = new System.Drawing.Point(174, 112);
            this.cmb_materias.Name = "cmb_materias";
            this.cmb_materias.Size = new System.Drawing.Size(151, 28);
            this.cmb_materias.TabIndex = 3;
            // 
            // ExportarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 406);
            this.Controls.Add(this.cmb_materias);
            this.Controls.Add(this.lbl_materias);
            this.Controls.Add(this.btn_json);
            this.Controls.Add(this.btn_csv);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportarAlumnos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ExportarAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Button btn_json;
        private System.Windows.Forms.Label lbl_materias;
        private System.Windows.Forms.ComboBox cmb_materias;
    }
}