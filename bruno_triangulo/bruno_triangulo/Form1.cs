using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruno_triangulo
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double valorA = double.Parse(txtLadoA.Text);
                double valorB = double.Parse(txtLadoB.Text);
                double valorC = double.Parse(txtLadoC.Text);

                if (valorA == 0 || valorB == 0 || valorC == 0)
                {
                    MessageBox.Show("Digitar valores válidos");
                }
                else if (Math.Abs(valorB - valorC) > valorA && valorA > (valorB + valorC))
                {
                    MessageBox.Show("Esta figura não forma um triângulo");
                }
                else if (Math.Abs(valorA - valorC) > valorB && valorB > (valorA + valorC))
                {
                    MessageBox.Show("Esta figura não forma um triângulo");
                }
                else if (Math.Abs(valorA - valorB) > valorC && valorC > (valorB + valorA))
                {
                    MessageBox.Show("Esta figura não forma um triângulo");
                }
                else
                {
                    if (valorA == valorB && valorB == valorC)
                    {
                        MessageBox.Show("Este é um triangulo Equilátero");
                    }
                    else if (valorA != valorB && valorA != valorC)
                    {
                        MessageBox.Show("Este é um triangulo Escaleno");
                    }
                    else
                    {
                        MessageBox.Show("Este é um triangulo Isósceles");
                    }

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Insira um número válido nos três campos");
            }
           
        }
    }
}
