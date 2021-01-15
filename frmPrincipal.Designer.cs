namespace Kinect1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        { 
            this.TxtIzquierdaX = new System.Windows.Forms.TextBox();
            this.TxtIzquierdaY = new System.Windows.Forms.TextBox();
            this.TxtDerechaX = new System.Windows.Forms.TextBox();
            this.TxtDerechaY = new System.Windows.Forms.TextBox();
            this.labelIzqX = new System.Windows.Forms.Label();
            this.labelIzqY = new System.Windows.Forms.Label();
            this.labelDerY = new System.Windows.Forms.Label();
            this.labelDerX = new System.Windows.Forms.Label();
            this.pnVectorContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtEscala = new System.Windows.Forms.TextBox();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIzquierdaX
            // 
            this.TxtIzquierdaX.Location = new System.Drawing.Point(497, 37);
            this.TxtIzquierdaX.Name = "TxtIzquierdaX";
            this.TxtIzquierdaX.Size = new System.Drawing.Size(100, 20);
            this.TxtIzquierdaX.TabIndex = 1;
            // 
            // TxtIzquierdaY
            // 
            this.TxtIzquierdaY.Location = new System.Drawing.Point(497, 66);
            this.TxtIzquierdaY.Name = "TxtIzquierdaY";
            this.TxtIzquierdaY.Size = new System.Drawing.Size(100, 20);
            this.TxtIzquierdaY.TabIndex = 2;
            // 
            // TxtDerechaX
            // 
            this.TxtDerechaX.Location = new System.Drawing.Point(497, 109);
            this.TxtDerechaX.Name = "TxtDerechaX";
            this.TxtDerechaX.Size = new System.Drawing.Size(100, 20);
            this.TxtDerechaX.TabIndex = 4;
            // 
            // TxtDerechaY
            // 
            this.TxtDerechaY.Location = new System.Drawing.Point(497, 135);
            this.TxtDerechaY.Name = "TxtDerechaY";
            this.TxtDerechaY.Size = new System.Drawing.Size(100, 20);
            this.TxtDerechaY.TabIndex = 5;
            // 
            // labelIzqX
            // 
            this.labelIzqX.AutoSize = true;
            this.labelIzqX.Location = new System.Drawing.Point(397, 40);
            this.labelIzqX.Name = "labelIzqX";
            this.labelIzqX.Size = new System.Drawing.Size(14, 13);
            this.labelIzqX.TabIndex = 6;
            this.labelIzqX.Text = "X";
            // 
            // labelIzqY
            // 
            this.labelIzqY.AutoSize = true;
            this.labelIzqY.Location = new System.Drawing.Point(397, 69);
            this.labelIzqY.Name = "labelIzqY";
            this.labelIzqY.Size = new System.Drawing.Size(14, 13);
            this.labelIzqY.TabIndex = 7;
            this.labelIzqY.Text = "Y";
            // 
            // labelDerY
            // 
            this.labelDerY.AutoSize = true;
            this.labelDerY.Location = new System.Drawing.Point(397, 138);
            this.labelDerY.Name = "labelDerY";
            this.labelDerY.Size = new System.Drawing.Size(14, 13);
            this.labelDerY.TabIndex = 8;
            this.labelDerY.Text = "Y";
            // 
            // labelDerX
            // 
            this.labelDerX.AutoSize = true;
            this.labelDerX.Location = new System.Drawing.Point(397, 112);
            this.labelDerX.Name = "labelDerX";
            this.labelDerX.Size = new System.Drawing.Size(14, 13);
            this.labelDerX.TabIndex = 9;
            this.labelDerX.Text = "X";
            // 
            // pnVectorContenedor
            // 
            this.pnVectorContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnVectorContenedor.Name = "pnVectorContenedor";
            this.pnVectorContenedor.Size = new System.Drawing.Size(391, 292);
            this.pnVectorContenedor.TabIndex = 12;
            this.pnVectorContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnVectorContenedor_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtEscala
            // 
            this.TxtEscala.Location = new System.Drawing.Point(497, 3);
            this.TxtEscala.Name = "TxtEscala";
            this.TxtEscala.Size = new System.Drawing.Size(100, 20);
            this.TxtEscala.TabIndex = 14;
            this.TxtEscala.Text = "10";
            this.TxtEscala.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(497, 203);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(497, 241);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Magnitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Escala";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMagnitud);
            this.Controls.Add(this.TxtEscala);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnVectorContenedor);
            this.Controls.Add(this.labelDerX);
            this.Controls.Add(this.labelDerY);
            this.Controls.Add(this.labelIzqY);
            this.Controls.Add(this.labelIzqX);
            this.Controls.Add(this.TxtDerechaY);
            this.Controls.Add(this.TxtDerechaX);
            this.Controls.Add(this.TxtIzquierdaY);
            this.Controls.Add(this.TxtIzquierdaX);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox TxtIzquierdaX;
        private System.Windows.Forms.TextBox TxtIzquierdaY;
        private System.Windows.Forms.TextBox TxtDerechaX;
        private System.Windows.Forms.TextBox TxtDerechaY;
        private System.Windows.Forms.Label labelIzqX;
        private System.Windows.Forms.Label labelIzqY;
        private System.Windows.Forms.Label labelDerY;
        private System.Windows.Forms.Label labelDerX;
        private System.Windows.Forms.Panel pnVectorContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtEscala;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

