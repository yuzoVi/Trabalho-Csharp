using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruno_peso
{
    public partial class frmPesoIdeal : Form
    {
        public frmPesoIdeal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = 0;
                double altura = 0;
                double peso_ideal = 0;

                altura = double.Parse(mkbxAltura.Text);
                peso = double.Parse(mkbxPeso.Text);

                if (rbtnFeminino.Checked)
                {
                    peso_ideal = (62.1 * altura) - 44.7;

                    if (peso > peso_ideal)
                    {
                        MessageBox.Show("“Regime Obrigatório Já”");
                    }

                    if (peso < peso_ideal)
                    {
                        MessageBox.Show("Coma bastante massas e doces!");
                    }

                    if (peso == peso_ideal)
                    {
                        MessageBox.Show("Você está no peso ideal");
                    }
                }


                if (rbtnMasculino.Checked)
                {
                    peso_ideal = (72.7 * altura) - 58;

                    if (peso > peso_ideal)
                    {
                        MessageBox.Show("“Regime Obrigatório Já”");
                    }

                    if (peso < peso_ideal)
                    {
                        MessageBox.Show("Coma bastante massas e doces!");
                    }

                    if (peso == peso_ideal)
                    {
                        MessageBox.Show("Você está no peso ideal");
                    }
                }

            }
            catch(System.FormatException)
            {
                MessageBox.Show("Insira valores válidos");
            }
        }
    }
}
