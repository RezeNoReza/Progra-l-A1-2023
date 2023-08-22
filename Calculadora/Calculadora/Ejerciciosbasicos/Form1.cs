using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerciciosbasicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCalculadora_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;

            Num1 =  double.Parse(txtNum1Calculadora.Text);
            Num2 = double.Parse(txtNum2Calculadora.Text);

            double resp = Num1 + Num2;

            MessageBox.Show("La Suma es: " + resp.ToString());
        }

        private void btnRestarCalculadora_Click(object sender, EventArgs e)
        {

            double Num1;
            double Num2;

            Num1 = double.Parse(txtNum1Calculadora.Text);
            Num2 = double.Parse(txtNum2Calculadora.Text);

            double resp = Num1 - Num2;

            MessageBox.Show("La Resta es: " + resp.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double Num1;
            double Num2;

            Num1 = double.Parse(txtNum1Calculadora.Text);
            Num2 = double.Parse(txtNum2Calculadora.Text);

            double resp = Num1 * Num2;

            MessageBox.Show("La Multiplicacion es: " + resp.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double Num1;
            double Num2;

            Num1 = double.Parse(txtNum1Calculadora.Text);
            Num2 = double.Parse(txtNum2Calculadora.Text);

            double resp = Num1 / Num2;

            MessageBox.Show("La Divison es: " + resp.ToString());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
