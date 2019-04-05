using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex40.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] matriz1 = new double[7, 5];
            matriz1[0, 0] = double.Parse(txt7x1.Text);
            matriz1[0, 1] = double.Parse(txt7x2.Text);
            matriz1[0, 2] = double.Parse(txt7x3.Text);
            matriz1[0, 3] = double.Parse(txt7x4.Text);
            matriz1[0, 4] = double.Parse(txt7x5.Text);
            matriz1[1, 0] = double.Parse(txt1x1.Text);
            matriz1[1, 1] = double.Parse(txt1x2.Text);
            matriz1[1, 2] = double.Parse(txt1x3.Text);
            matriz1[1, 3] = double.Parse(txt1x4.Text);
            matriz1[1, 4] = double.Parse(txt1x5.Text);
            matriz1[2, 0] = double.Parse(txt2x1.Text);
            matriz1[2, 1] = double.Parse(txt2x2.Text);
            matriz1[2, 2] = double.Parse(txt2x3.Text);
            matriz1[2, 3] = double.Parse(txt2x4.Text);
            matriz1[2, 4] = double.Parse(txt2x5.Text);
            matriz1[3, 0] = double.Parse(txt3x1.Text);
            matriz1[3, 1] = double.Parse(txt3x2.Text);
            matriz1[3, 2] = double.Parse(txt3x3.Text);
            matriz1[3, 3] = double.Parse(txt3x4.Text);
            matriz1[3, 4] = double.Parse(txt3x5.Text);
            matriz1[4, 0] = double.Parse(txt4x1.Text);
            matriz1[4, 1] = double.Parse(txt4x2.Text);
            matriz1[4, 2] = double.Parse(txt4x3.Text);
            matriz1[4, 3] = double.Parse(txt4x4.Text);
            matriz1[4, 4] = double.Parse(txt4x5.Text);
            matriz1[5, 0] = double.Parse(txt5x1.Text);
            matriz1[5, 1] = double.Parse(txt5x2.Text);
            matriz1[5, 2] = double.Parse(txt5x3.Text);
            matriz1[5, 3] = double.Parse(txt5x4.Text);
            matriz1[5, 4] = double.Parse(txt5x5.Text);
            matriz1[6, 0] = double.Parse(txt6x1.Text);
            matriz1[6, 1] = double.Parse(txt6x2.Text);
            matriz1[6, 2] = double.Parse(txt6x3.Text);
            matriz1[6, 3] = double.Parse(txt6x4.Text);
            matriz1[6, 4] = double.Parse(txt6x5.Text);
          

            double[] totalPorDia = new double[7];
            for (int i = 0; i <= 6; i++)
            {
                totalPorDia[i] = matriz1[i, 0] + matriz1[i, 1] + matriz1[i, 2] + matriz1[i, 3] + matriz1[i, 4];
            }

            double somaGeral = 0;
            for(int i = 0; i <= 6; i++)
            {
                somaGeral += totalPorDia[i];
            }
            string x;
            x = somaGeral.ToString();

            string totalPorDiaS = String.Join(", ", totalPorDia);

            MessageBox.Show("Total por Dia: " + totalPorDiaS + "\n Total geral: " + somaGeral );
        }
    }
}
