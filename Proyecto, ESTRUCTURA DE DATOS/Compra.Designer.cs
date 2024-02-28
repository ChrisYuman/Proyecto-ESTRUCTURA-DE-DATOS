namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    partial class Compra
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(374, 125);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "button1";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(503, 125);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "button2";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(70, 126);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Name = "Compra";
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button button1;
    }
}