namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    partial class RegistrarProductos
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
            this.Nombre = new System.Windows.Forms.Label();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(78, 45);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(81, 297);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(108, 43);
            this.btnRegistrarProducto.TabIndex = 1;
            this.btnRegistrarProducto.Text = "Registrar";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(81, 78);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(81, 250);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Location = new System.Drawing.Point(336, 121);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadDisponible.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(336, 213);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(81, 397);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(766, 150);
            this.dataGridViewProductos.TabIndex = 9;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(336, 297);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(90, 43);
            this.btnCargarArchivo.TabIndex = 10;
            this.btnCargarArchivo.Text = "Cargar";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(751, 36);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 35);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(81, 167);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtCategoria.TabIndex = 13;
            // 
            // RegistrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 643);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.Nombre);
            this.Name = "RegistrarProductos";
            this.Text = "RegistrarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}