namespace Forms
{
    partial class CrearExamenProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearExamenProfesor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreExamen = new System.Windows.Forms.TextBox();
            this.cmb_nombreMateria = new System.Windows.Forms.ComboBox();
            this.dtp_fechaExamen = new System.Windows.Forms.DateTimePicker();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre examen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(119, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materia:";
            // 
            // txt_nombreExamen
            // 
            this.txt_nombreExamen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreExamen.Location = new System.Drawing.Point(256, 46);
            this.txt_nombreExamen.Name = "txt_nombreExamen";
            this.txt_nombreExamen.Size = new System.Drawing.Size(132, 30);
            this.txt_nombreExamen.TabIndex = 10;
            // 
            // cmb_nombreMateria
            // 
            this.cmb_nombreMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nombreMateria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_nombreMateria.FormattingEnabled = true;
            this.cmb_nombreMateria.Location = new System.Drawing.Point(256, 123);
            this.cmb_nombreMateria.Name = "cmb_nombreMateria";
            this.cmb_nombreMateria.Size = new System.Drawing.Size(132, 31);
            this.cmb_nombreMateria.TabIndex = 11;
            // 
            // dtp_fechaExamen
            // 
            this.dtp_fechaExamen.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.dtp_fechaExamen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_fechaExamen.Location = new System.Drawing.Point(92, 206);
            this.dtp_fechaExamen.Name = "dtp_fechaExamen";
            this.dtp_fechaExamen.Size = new System.Drawing.Size(323, 30);
            this.dtp_fechaExamen.TabIndex = 13;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_confirmar.Location = new System.Drawing.Point(140, 295);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(205, 72);
            this.btn_confirmar.TabIndex = 14;
            this.btn_confirmar.Text = "Aceptar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // CrearExamenProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 428);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.dtp_fechaExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_nombreMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombreExamen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearExamenProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Examen";
            this.Load += new System.EventHandler(this.CrearExamenProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreExamen;
        private System.Windows.Forms.ComboBox cmb_nombreMateria;
        private System.Windows.Forms.DateTimePicker dtp_fechaExamen;
        private System.Windows.Forms.Button btn_confirmar;
    }
}