using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario_bruno
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string nomeFunc = mskNomeFunc.Text;
            double salarioBruto = double.Parse(MskSalBruto.Text);
            int numFilhos = Int32.Parse(mskNumFilhos.Text);

            double alINSS = 0;
            double descontoINSS = 0;
            if(salarioBruto <= 800.47)
            {
                alINSS = 7.65;
            }

            if(salarioBruto >= 800.48 && salarioBruto <= 1050)
            {
                alINSS = 8.65;
            }

            if(salarioBruto >= 1050.1 && salarioBruto <= 1400.77)
            {
                alINSS = 9;
            }

            if (salarioBruto >= 1400.78 && salarioBruto<= 2801.56)
            {
                alINSS = 11;
            }

            if(salarioBruto  > 2801.56)
            {
                descontoINSS = 308.17;
                mskINSS.Text = "MAX";
                mskDINSS.Text = "308.17";
            }
            else
            {
                mskINSS.Text = String.Concat(Convert.ToString(alINSS), "%");
                descontoINSS = (salarioBruto * alINSS) / 100;
                mskDINSS.Text = Convert.ToString(descontoINSS);
            }


            double alIRRF = 0;
            double descontoIRRF = 0;

            if(salarioBruto <= 1257.12)
            {
                mskDIRRF.Text = "ISENTO";
                mskIRRF.Text = "ISENTO";
            }
            else
            {
                if(salarioBruto>= 1257.13 && salarioBruto <= 2512.08)
                {
                    alIRRF = 15;
                }

                if(salarioBruto > 2512.08)
                {
                    alIRRF = 27.5;
                }

                mskIRRF.Text = String.Concat(Convert.ToString(alIRRF), "%");
                descontoIRRF = (alIRRF * salarioBruto) / 100;
                mskDIRRF.Text = Convert.ToString(descontoIRRF);
            }

            double salFamilia = 0;
            if(salarioBruto <= 435.52)
            {
                salFamilia = 22.33 *numFilhos;
            }

            if(salarioBruto >= 435.53 && salarioBruto <= 654.61)
            {
                salFamilia = 15.74 *numFilhos;
            }

            if(salarioBruto > 654.61)
            {
                salFamilia = 0;
            }


            double salLiquido = 0;
            salLiquido = salarioBruto - descontoIRRF - descontoIRRF + salFamilia;

            mskSalLiquido.Text = Convert.ToString(salLiquido);

            if(ckbxCasado.Checked == true)
            {
                lblDados.Text = String.Concat("Os descontos do salário do(a) ", nomeFunc, " que é Casado(a) e que tem ",
                Convert.ToString(numFilhos), " filho(s) são: ");
            }
            else
            {
                lblDados.Text = String.Concat("Os descontos do salário do(a) ", nomeFunc, " que é Solteiro(a) e que tem ",
                Convert.ToString(numFilhos), " filho(s) são: ");
            }
            
        }
    }
}
