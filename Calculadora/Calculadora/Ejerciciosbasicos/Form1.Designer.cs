
namespace Ejerciciosbasicos
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
            this.btnCalcularCalculadora = new System.Windows.Forms.Button();
            this.lblNum1Calculadora = new System.Windows.Forms.Label();
            this.txtNum1Calculadora = new System.Windows.Forms.TextBox();
            this.lblNum2Calculadora = new System.Windows.Forms.Label();
            this.txtNum2Calculadora = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnRestarCalculadora = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularCalculadora
            // 
            this.btnCalcularCalculadora.Location = new System.Drawing.Point(394, 256);
            this.btnCalcularCalculadora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularCalculadora.Name = "btnCalcularCalculadora";
            this.btnCalcularCalculadora.Size = new System.Drawing.Size(112, 34);
            this.btnCalcularCalculadora.TabIndex = 0;
            this.btnCalcularCalculadora.Text = "Calcular Suma";
            this.btnCalcularCalculadora.UseVisualStyleBackColor = true;
            this.btnCalcularCalculadora.Click += new System.EventHandler(this.btnCalcularCalculadora_Click);
            // 
            // lblNum1Calculadora
            // 
            this.lblNum1Calculadora.AutoSize = true;
            this.lblNum1Calculadora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1Calculadora.Location = new System.Drawing.Point(170, 127);
            this.lblNum1Calculadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1Calculadora.Name = "lblNum1Calculadora";
            this.lblNum1Calculadora.Size = new System.Drawing.Size(50, 19);
            this.lblNum1Calculadora.TabIndex = 1;
            this.lblNum1Calculadora.Text = "Num1:";
            // 
            // txtNum1Calculadora
            // 
            this.txtNum1Calculadora.Location = new System.Drawing.Point(271, 124);
            this.txtNum1Calculadora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum1Calculadora.Multiline = true;
            this.txtNum1Calculadora.Name = "txtNum1Calculadora";
            this.txtNum1Calculadora.Size = new System.Drawing.Size(235, 39);
            this.txtNum1Calculadora.TabIndex = 2;
            // 
            // lblNum2Calculadora
            // 
            this.lblNum2Calculadora.AutoSize = true;
            this.lblNum2Calculadora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2Calculadora.Location = new System.Drawing.Point(170, 215);
            this.lblNum2Calculadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2Calculadora.Name = "lblNum2Calculadora";
            this.lblNum2Calculadora.Size = new System.Drawing.Size(50, 19);
            this.lblNum2Calculadora.TabIndex = 3;
            this.lblNum2Calculadora.Text = "Num2:";
            // 
            // txtNum2Calculadora
            // 
            this.txtNum2Calculadora.Location = new System.Drawing.Point(271, 195);
            this.txtNum2Calculadora.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum2Calculadora.Multiline = true;
            this.txtNum2Calculadora.Name = "txtNum2Calculadora";
            this.txtNum2Calculadora.Size = new System.Drawing.Size(235, 39);
            this.txtNum2Calculadora.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(361, 264);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 19);
            this.lblRespuesta.TabIndex = 5;
            // 
            // btnRestarCalculadora
            // 
            this.btnRestarCalculadora.Location = new System.Drawing.Point(215, 256);
            this.btnRestarCalculadora.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestarCalculadora.Name = "btnRestarCalculadora";
            this.btnRestarCalculadora.Size = new System.Drawing.Size(112, 34);
            this.btnRestarCalculadora.TabIndex = 6;
            this.btnRestarCalculadora.Text = "Calcular Resta";
            this.btnRestarCalculadora.UseVisualStyleBackColor = true;
            this.btnRestarCalculadora.Click += new System.EventHandler(this.btnRestarCalculadora_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Calcular Division";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 410);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestarCalculadora);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtNum2Calculadora);
            this.Controls.Add(this.lblNum2Calculadora);
            this.Controls.Add(this.txtNum1Calculadora);
            this.Controls.Add(this.lblNum1Calculadora);
            this.Controls.Add(this.btnCalcularCalculadora);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCalculadora;
        private System.Windows.Forms.Label lblNum1Calculadora;
        private System.Windows.Forms.TextBox txtNum1Calculadora;
        private System.Windows.Forms.Label lblNum2Calculadora;
        private System.Windows.Forms.TextBox txtNum2Calculadora;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnRestarCalculadora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
    }
}

