namespace Forms
{
    partial class DataGridAlumnosProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridAlumnosProfesor));
            this.dgv_alumnosProfe = new System.Windows.Forms.DataGridView();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnosProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alumnosProfe
            // 
            this.dgv_alumnosProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumnosProfe.Location = new System.Drawing.Point(12, 12);
            this.dgv_alumnosProfe.Name = "dgv_alumnosProfe";
            this.dgv_alumnosProfe.RowHeadersWidth = 51;
            this.dgv_alumnosProfe.RowTemplate.Height = 29;
            this.dgv_alumnosProfe.Size = new System.Drawing.Size(555, 303);
            this.dgv_alumnosProfe.TabIndex = 0;
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_materia.Location = new System.Drawing.Point(596, 53);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(153, 25);
            this.lbl_materia.TabIndex = 1;
            this.lbl_materia.Text = "Elegir Materia";
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(598, 117);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(151, 28);
            this.cmb_materia.TabIndex = 2;
            this.cmb_materia.SelectedIndexChanged += new System.EventHandler(this.cmb_materia_SelectedIndexChanged);
            // 
            // DataGridAlumnosProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.dgv_alumnosProfe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataGridAlumnosProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Alumnos";
            this.Load += new System.EventHandler(this.DataGridAlumnosProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnosProfe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alumnosProfe;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.ComboBox cmb_materia;
    }
}