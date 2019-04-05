using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program38.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mskbxNum.Text = "00";
            mskbxNum.Focus();
            ActiveControl = mskbxNum;

        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = int.Parse(mskbxNum.Text);
            if(num >0 && num <= 50)
            {
                double resultado = 0;
                for (int x = 1; x <= num; x++)
                    resultado += (double)x / (x + 1);

                MessageBox.Show("O valor da soma é : " + resultado);
            }
            else
            {
                MessageBox.Show("Digite um número maior que zero e menor que 50");
            }
            mskbxNum.Text = "00";
            mskbxNum.Focus();
            ActiveControl = mskbxNum;
        }
    }
}
