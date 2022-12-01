using Forms.Properties;

namespace Forms
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.btn_asignarMateriaMenu = new System.Windows.Forms.Button();
            this.lbl_bienvenidoAdmin = new System.Windows.Forms.Label();
            this.btn_cambiarEstadoMateriaA = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_formAgregarMateria = new System.Windows.Forms.Button();
            this.btn_altaUsuario = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_importar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_asignarMateriaMenu
            // 
            this.btn_asignarMateriaMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_asignarMateriaMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_asignarMateriaMenu.Location = new System.Drawing.Point(78, 245);
            this.btn_asignarMateriaMenu.Name = "btn_asignarMateriaMenu";
            this.btn_asignarMateriaMenu.Size = new System.Drawing.Size(222, 79);
            this.btn_asignarMateriaMenu.TabIndex = 17;
            this.btn_asignarMateriaMenu.Text = "Asignar profesor a materia";
            this.btn_asignarMateriaMenu.UseVisualStyleBackColor = true;
            this.btn_asignarMateriaMenu.Click += new System.EventHandler(this.btn_altaProfesorMat_Click);
            // 
            // lbl_bienvenidoAdmin
            // 
            this.lbl_bienvenidoAdmin.AutoSize = true;
            this.lbl_bienvenidoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenidoAdmin.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenidoAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_bienvenidoAdmin.Location = new System.Drawing.Point(115, 26);
            this.lbl_bienvenidoAdmin.Name = "lbl_bienvenidoAdmin";
            this.lbl_bienvenidoAdmin.Size = new System.Drawing.Size(223, 40);
            this.lbl_bienvenidoAdmin.TabIndex = 23;
            this.lbl_bienvenidoAdmin.Text = "Bienvenido";
            // 
            // btn_cambiarEstadoMateriaA
            // 
            this.btn_cambiarEstadoMateriaA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarEstadoMateriaA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cambiarEstadoMateriaA.Location = new System.Drawing.Point(391, 245);
            this.btn_cambiarEstadoMateriaA.Name = "btn_cambiarEstadoMateriaA";
            this.btn_cambiarEstadoMateriaA.Size = new System.Drawing.Size(227, 79);
            this.btn_cambiarEstadoMateriaA.TabIndex = 30;
            this.btn_cambiarEstadoMateriaA.Text = "Confirmar cambio de estado";
            this.btn_cambiarEstadoMateriaA.UseVisualStyleBackColor = true;
            this.btn_cambiarEstadoMateriaA.Click += new System.EventHandler(this.btn_cambiarEstadoMateriaA_Click);
            // 
            // btn_formAgregarMateria
            // 
            this.btn_formAgregarMateria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_formAgregarMateria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_formAgregarMateria.Location = new System.Drawing.Point(391, 109);
            this.btn_formAgregarMateria.Name = "btn_formAgregarMateria";
            this.btn_formAgregarMateria.Size = new System.Drawing.Size(227, 70);
            this.btn_formAgregarMateria.TabIndex = 36;
            this.btn_formAgregarMateria.Text = "Agregar Materia";
            this.btn_formAgregarMateria.UseVisualStyleBackColor = true;
            this.btn_formAgregarMateria.Click += new System.EventHandler(this.btn_formAgregarMateria_Click_1);
            // 
            // btn_altaUsuario
            // 
            this.btn_altaUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_altaUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_altaUsuario.Location = new System.Drawing.Point(78, 109);
            this.btn_altaUsuario.Name = "btn_altaUsuario";
            this.btn_altaUsuario.Size = new System.Drawing.Size(222, 70);
            this.btn_altaUsuario.TabIndex = 37;
            this.btn_altaUsuario.Text = "Alta usuario";
            this.btn_altaUsuario.UseVisualStyleBackColor = true;
            this.btn_altaUsuario.Click += new System.EventHandler(this.btn_altaUsuario_Click_1);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exportar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_exportar.Location = new System.Drawing.Point(391, 368);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(227, 77);
            this.btn_exportar.TabIndex = 38;
            this.btn_exportar.Text = "Exportar Alumnos";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(78, 368);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(222, 77);
            this.btn_importar.TabIndex = 39;
            this.btn_importar.Text = "importar Alumnos";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Forms.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 511);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_altaUsuario);
            this.Controls.Add(this.btn_formAgregarMateria);
            this.Controls.Add(this.btn_cambiarEstadoMateriaA);
            this.Controls.Add(this.lbl_bienvenidoAdmin);
            this.Controls.Add(this.btn_asignarMateriaMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_asignarMateriaMenu;
        private System.Windows.Forms.Label lbl_bienvenidoAdmin;
        private System.Windows.Forms.Button btn_cambiarEstadoMateriaA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_formAgregarMateria;
        private System.Windows.Forms.Button btn_altaUsuario;
        private System.Windows.Forms.Button btn_exportar;
        private Button btn_importar;
    }
}