namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    partial class Pagina_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina_principal));
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.ToolTip(this.components);
            this.Buscar = new System.Windows.Forms.ToolTip(this.components);
            this.CompraYventa = new System.Windows.Forms.ToolTip(this.components);
            this.Actualizar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(167, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 170);
            this.button1.TabIndex = 0;
            this.Registrar.SetToolTip(this.button1, "Registrar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(534, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 170);
            this.btnBuscar.TabIndex = 1;
            this.Buscar.SetToolTip(this.btnBuscar, "Buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(167, 313);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(198, 181);
            this.button2.TabIndex = 2;
            this.CompraYventa.SetToolTip(this.button2, "Compra Y Venta");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(534, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 170);
            this.button3.TabIndex = 3;
            this.Actualizar.SetToolTip(this.button3, "Actualizar");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registrar
            // 
            this.Registrar.ToolTipTitle = "Registrar";
            this.Registrar.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Buscar
            // 
            this.Buscar.ToolTipTitle = "Buscar";
            // 
            // CompraYventa
            // 
            this.CompraYventa.ToolTipTitle = "Compra Y Venta";
            // 
            // Actualizar
            // 
            this.Actualizar.ToolTipTitle = "Actualizar";
            this.Actualizar.Popup += new System.Windows.Forms.PopupEventHandler(this.Actualizar_Popup);
            // 
            // Pagina_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(886, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Name = "Pagina_principal";
            this.Text = "Pagina_principal";
            this.Load += new System.EventHandler(this.Pagina_principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip Registrar;
        private System.Windows.Forms.ToolTip Buscar;
        private System.Windows.Forms.ToolTip CompraYventa;
        private System.Windows.Forms.ToolTip Actualizar;
    }
}