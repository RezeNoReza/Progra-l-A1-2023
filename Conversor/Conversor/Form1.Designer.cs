
namespace Conversor
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
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.lblConversores = new System.Windows.Forms.Label();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.cboAconversores = new System.Windows.Forms.ComboBox();
            this.lblAconversores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRespuestaCoversores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(229, 338);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(187, 59);
            this.btnConvertirConversores.TabIndex = 0;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // lblConversores
            // 
            this.lblConversores.AutoSize = true;
            this.lblConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversores.Location = new System.Drawing.Point(225, 108);
            this.lblConversores.Name = "lblConversores";
            this.lblConversores.Size = new System.Drawing.Size(35, 22);
            this.lblConversores.TabIndex = 1;
            this.lblConversores.Text = "De";
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro ",
            "Quetzales ",
            "Lempiras",
            "Colon sv",
            "Cordoba",
            "Pesos cr",
            "Yen",
            "Libras esterlinas",
            "Rupia india"});
            this.cboDeConversores.Location = new System.Drawing.Point(290, 109);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(121, 21);
            this.cboDeConversores.TabIndex = 2;
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(311, 174);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadConversores.TabIndex = 3;
            // 
            // cboAconversores
            // 
            this.cboAconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAconversores.FormattingEnabled = true;
            this.cboAconversores.Items.AddRange(new object[] {
            "Dolar",
            "Euro ",
            "Quetzales ",
            "Lempiras",
            "Colon sv",
            "Cordoba",
            "Pesos cr",
            "Yen",
            "Libras esterlinas",
            "Rupia india"});
            this.cboAconversores.Location = new System.Drawing.Point(290, 136);
            this.cboAconversores.Name = "cboAconversores";
            this.cboAconversores.Size = new System.Drawing.Size(121, 21);
            this.cboAconversores.TabIndex = 5;
            // 
            // lblAconversores
            // 
            this.lblAconversores.AutoSize = true;
            this.lblAconversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAconversores.Location = new System.Drawing.Point(225, 135);
            this.lblAconversores.Name = "lblAconversores";
            this.lblAconversores.Size = new System.Drawing.Size(23, 22);
            this.lblAconversores.TabIndex = 4;
            this.lblAconversores.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // lblRespuestaCoversores
            // 
            this.lblRespuestaCoversores.AutoSize = true;
            this.lblRespuestaCoversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaCoversores.Location = new System.Drawing.Point(225, 255);
            this.lblRespuestaCoversores.Name = "lblRespuestaCoversores";
            this.lblRespuestaCoversores.Size = new System.Drawing.Size(118, 22);
            this.lblRespuestaCoversores.TabIndex = 7;
            this.lblRespuestaCoversores.Text = "Respuesta ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRespuestaCoversores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAconversores);
            this.Controls.Add(this.lblAconversores);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.lblConversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.Label lblConversores;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.ComboBox cboAconversores;
        private System.Windows.Forms.Label lblAconversores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuestaCoversores;
    }
}

