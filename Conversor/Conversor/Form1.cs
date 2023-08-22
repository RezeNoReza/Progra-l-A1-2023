using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            {
                int de = 0, a = 0;
                double cantidad = 0, respuesta = 0;
                de = cboDeConversores.SelectedIndex;
                a = cboAconversores.SelectedIndex;

                cantidad = double.Parse(txtCantidadConversores.Text);
                /*Dolar
                Euro 
                Quetzales 
                Lempiras
                Colon sv
                Cordoba
                Pesos cr
                Yen
                Libras esterlinas
                Rupia india 
                */
                double[] monedas = { 1, 0.92, 7.86, 24.62, 8.75, 36.56, 535.14, 145.47, 0.79, 83.32 };
                respuesta = monedas[a] / monedas[de] * cantidad;

                lblRespuestaCoversores.Text = "respuesta" + Math.Round(respuesta, 3);

            }
        }
    }
}
    

