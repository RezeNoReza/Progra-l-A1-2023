
namespace RezaParcial1
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
            this.BtnPower = new System.Windows.Forms.Button();
            this.LblCantidadConversores = new System.Windows.Forms.Label();
            this.LblAConversor = new System.Windows.Forms.Label();
            this.LblDeConversor = new System.Windows.Forms.Label();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.TxtMakima = new System.Windows.Forms.TextBox();
            this.CboAki = new System.Windows.Forms.ComboBox();
            this.CboDenji = new System.Windows.Forms.ComboBox();
            this.CboReze = new System.Windows.Forms.ComboBox();
            this.LblNayuta = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPower
            // 
            this.BtnPower.Location = new System.Drawing.Point(367, 298);
            this.BtnPower.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(99, 37);
            this.BtnPower.TabIndex = 28;
            this.BtnPower.Text = "Convertir";
            this.BtnPower.UseVisualStyleBackColor = true;
            this.BtnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // LblCantidadConversores
            // 
            this.LblCantidadConversores.AutoSize = true;
            this.LblCantidadConversores.Location = new System.Drawing.Point(274, 217);
            this.LblCantidadConversores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadConversores.Name = "LblCantidadConversores";
            this.LblCantidadConversores.Size = new System.Drawing.Size(49, 13);
            this.LblCantidadConversores.TabIndex = 27;
            this.LblCantidadConversores.Text = "Cantidad";
            // 
            // LblAConversor
            // 
            this.LblAConversor.AutoSize = true;
            this.LblAConversor.Location = new System.Drawing.Point(313, 177);
            this.LblAConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAConversor.Name = "LblAConversor";
            this.LblAConversor.Size = new System.Drawing.Size(17, 13);
            this.LblAConversor.TabIndex = 26;
            this.LblAConversor.Text = "A:";
            // 
            // LblDeConversor
            // 
            this.LblDeConversor.AutoSize = true;
            this.LblDeConversor.Location = new System.Drawing.Point(306, 139);
            this.LblDeConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeConversor.Name = "LblDeConversor";
            this.LblDeConversor.Size = new System.Drawing.Size(24, 13);
            this.LblDeConversor.TabIndex = 25;
            this.LblDeConversor.Text = "De:";
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(299, 94);
            this.lblTipoConversor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(31, 13);
            this.lblTipoConversor.TabIndex = 24;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // TxtMakima
            // 
            this.TxtMakima.Location = new System.Drawing.Point(334, 214);
            this.TxtMakima.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMakima.Name = "TxtMakima";
            this.TxtMakima.Size = new System.Drawing.Size(156, 20);
            this.TxtMakima.TabIndex = 23;
            // 
            // CboAki
            // 
            this.CboAki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAki.FormattingEnabled = true;
            this.CboAki.Location = new System.Drawing.Point(334, 174);
            this.CboAki.Margin = new System.Windows.Forms.Padding(2);
            this.CboAki.Name = "CboAki";
            this.CboAki.Size = new System.Drawing.Size(156, 21);
            this.CboAki.TabIndex = 22;
            // 
            // CboDenji
            // 
            this.CboDenji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDenji.FormattingEnabled = true;
            this.CboDenji.Location = new System.Drawing.Point(334, 136);
            this.CboDenji.Margin = new System.Windows.Forms.Padding(2);
            this.CboDenji.Name = "CboDenji";
            this.CboDenji.Size = new System.Drawing.Size(156, 21);
            this.CboDenji.TabIndex = 21;
            // 
            // CboReze
            // 
            this.CboReze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboReze.FormattingEnabled = true;
            this.CboReze.Items.AddRange(new object[] {
            "Area"});
            this.CboReze.Location = new System.Drawing.Point(334, 91);
            this.CboReze.Margin = new System.Windows.Forms.Padding(2);
            this.CboReze.Name = "CboReze";
            this.CboReze.Size = new System.Drawing.Size(156, 21);
            this.CboReze.TabIndex = 20;
            this.CboReze.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // LblNayuta
            // 
            this.LblNayuta.AutoSize = true;
            this.LblNayuta.Location = new System.Drawing.Point(274, 262);
            this.LblNayuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNayuta.Name = "LblNayuta";
            this.LblNayuta.Size = new System.Drawing.Size(64, 13);
            this.LblNayuta.TabIndex = 19;
            this.LblNayuta.Text = "Respuesta: ";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(306, 93);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(0, 13);
            this.lbltipo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPower);
            this.Controls.Add(this.LblCantidadConversores);
            this.Controls.Add(this.LblAConversor);
            this.Controls.Add(this.LblDeConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.TxtMakima);
            this.Controls.Add(this.CboAki);
            this.Controls.Add(this.CboDenji);
            this.Controls.Add(this.CboReze);
            this.Controls.Add(this.LblNayuta);
            this.Controls.Add(this.lbltipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPower;
        private System.Windows.Forms.Label LblCantidadConversores;
        private System.Windows.Forms.Label LblAConversor;
        private System.Windows.Forms.Label LblDeConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.TextBox TxtMakima;
        private System.Windows.Forms.ComboBox CboAki;
        private System.Windows.Forms.ComboBox CboDenji;
        private System.Windows.Forms.ComboBox CboReze;
        private System.Windows.Forms.Label LblNayuta;
        private System.Windows.Forms.Label lbltipo;
    }
}

