namespace clases_y_objetos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.correoIn = new System.Windows.Forms.TextBox();
            this.salida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoIn = new System.Windows.Forms.TextBox();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValidacionPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(536, 75);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(75, 23);
            this.btnvalidar.TabIndex = 0;
            this.btnvalidar.Text = "validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // correoIn
            // 
            this.correoIn.Location = new System.Drawing.Point(202, 105);
            this.correoIn.Name = "correoIn";
            this.correoIn.Size = new System.Drawing.Size(152, 20);
            this.correoIn.TabIndex = 2;
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(404, 340);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(19, 13);
            this.salida.TabIndex = 3;
            this.salida.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // codigoIn
            // 
            this.codigoIn.Location = new System.Drawing.Point(202, 79);
            this.codigoIn.Name = "codigoIn";
            this.codigoIn.Size = new System.Drawing.Size(152, 20);
            this.codigoIn.TabIndex = 6;
            // 
            // nombreIn
            // 
            this.nombreIn.Location = new System.Drawing.Point(202, 49);
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(151, 20);
            this.nombreIn.TabIndex = 7;
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "password";
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(202, 154);
            this.txClave.Name = "txClave";
            this.txClave.Size = new System.Drawing.Size(151, 20);
            this.txClave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "debe tener minino 6 caracteres, debe tener un caracter especial (*, $,  /, #) ";
            // 
            // lblValidacionPass
            // 
            this.lblValidacionPass.AutoSize = true;
            this.lblValidacionPass.Location = new System.Drawing.Point(380, 160);
            this.lblValidacionPass.Name = "lblValidacionPass";
            this.lblValidacionPass.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionPass.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidacionPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.codigoIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.correoIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvalidar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correoIn;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoIn;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValidacionPass;
    }
}

