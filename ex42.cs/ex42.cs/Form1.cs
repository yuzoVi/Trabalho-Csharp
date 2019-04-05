using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex42.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = txtDe;
            txtDe.Focus();
            txtPara.Text = "0";
            txtDe.Text = "0";
        }
        private void cbxMedidas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPara.Text = "0";
            txtDe.Text = "0";
            this.ActiveControl = txtDe;
            txtDe.Focus();
        }

        private void txtDe_MouseClick(object sender, MouseEventArgs e)
        {
            txtDe.Text = String.Empty;
            txtPara.Text = String.Empty;
        }

        private void txtPara_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyData == Keys.Enter)
                {
                double numDe = 0, numPara = 0;
                numPara = double.Parse(txtPara.Text);
                string fator = cbxMedidas.Text;

                switch (fator)
                {
                    case "De Arroba Para Quilo": numDe = numPara / 15; break;
                    case "De Libra Para Quilo": numDe = numPara / 0.4535923; break;
                    case "De Onça Para Grama": numDe = numPara / 28.349; break;
                    case "De Acre Para Hectare": numDe = numPara / 0.4046856224; break;
                    case "De Hectare Para Metro2": numDe = numPara / 10000.0; break;
                    case "De AlqueireMG Para Hectare": numDe = numPara / 4.84; break;
                    case "De AlqueireSP Para Hectare": numDe = numPara / 2.42; break;
                    case "De AlqueireNorte Para Hectare": numDe = numPara / 2.72; break;
                    case "De Braça Para Metro": numDe = numPara / 1.8288; break;
                    case "De Jarda Para Metro": numDe = numPara / 0.9144; break;
                    case "De Pé Para Centímetro": numDe = numPara / 30.48; break;
                    case "De Polegada Para Centímetro": numDe = numPara / 2.54; break;
                    case "De Milha Para Quilometro": numDe = numPara / 1.609344; break;
                }
                txtDe.Text = numDe.ToString();
            }
            }

        private void txtDe_KeyPress(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyData == Keys.Enter)
                {
                    double numDe = 0, numPara = 0;
                    numDe = double.Parse(txtDe.Text);
                    string fator = cbxMedidas.Text;

                    switch (fator)
                    {
                        case "De Arroba Para Quilo": numPara = numDe * 15; break;
                        case "De Libra Para Quilo": numPara = numDe * 0.4535923; break;
                        case "De Onça Para Grama": numPara = numDe * 28.349; break;
                        case "De Acre Para Hectare": numPara = numDe * 0.4046856224; break;
                        case "De Hectare Para Metro2": numPara = numDe * 10000.0; break;
                        case "De AlqueireMG Para Hectare": numPara = numDe * 4.84; break;
                        case "De AlqueireSP Para Hectare": numPara = numDe * 2.42; break;
                        case "De AlqueireNorte Para Hectare": numPara = numDe * 2.72; break;
                        case "De Braça Para Metro": numPara = numDe * 1.8288; break;
                        case "De Jarda Para Metro": numPara = numDe * 0.9144; break;
                        case "De Pé Para Centímetro": numPara = numDe * 30.48; break;
                        case "De Polegada Para Centímetro": numPara = numDe * 2.54; break;
                        case "De Milha Para Quilometro": numPara = numDe * 1.609344; break;
                    }
                    txtPara.Text = numPara.ToString();
                }
            }
        }
    }
    }

