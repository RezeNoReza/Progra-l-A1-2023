using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezaParcial1
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][] {
       new string[] {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzanas", "Hectarias"}, //Reze Estuvo Aqui 
       };


        public Form1()
        {
            InitializeComponent();
        }



        private void CboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            CboDenji.Items.Clear();
            CboDenji.Items.AddRange(TiposConversores[CboReze.SelectedIndex]);

            CboAki.Items.Clear();
            CboAki.Items.AddRange(TiposConversores[CboReze.SelectedIndex]);

        }

        

        private void BtnPower_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = CboDenji.SelectedIndex;
            a = CboAki.SelectedIndex;

            cantidad = double.Parse(TxtMakima.Text);

            double[][] area = {
            new double []{0.09290304, 0.698896, 0.836127, 1, 437.5, 7000, 10.000, },
           };
            respuesta = area[CboReze.SelectedIndex][de] / area[CboReze.SelectedIndex][a] * cantidad;

            LblNayuta.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}