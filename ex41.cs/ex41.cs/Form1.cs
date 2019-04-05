using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex41.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = txtNome;
            mskbxSalario.Text = "0000.00";
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome, ultimaEmpresa, telefone, idade, distancia, tempoExp;
            float salarioPretendido;

            nome = txtNome.Text;
            ultimaEmpresa = txtEmpresa.Text;
            telefone = txtTelefone.Text;
            idade = cbxIdade.Text;
            distancia = cbxDistancia.Text;
            tempoExp = cbxTempo.Text;
            salarioPretendido = float.Parse(mskbxSalario.Text);


            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(ultimaEmpresa) ||
                string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(idade) ||
                string.IsNullOrWhiteSpace(distancia) || string.IsNullOrWhiteSpace(tempoExp) ||
                salarioPretendido <= 0)
            {
                MessageBox.Show("Preencha todos os campos do formulário!");
            }
            else if (ckBxMasculino.Checked == false && ckbxFeminino.Checked == false)
            {
                MessageBox.Show("Preencha todos os campos do formulário!");
            }
            else if (distancia == "100KM +")
            {
                MessageBox.Show("Obrigado, mas a empresa não disponibiliza transporte");
            }
            else if (salarioPretendido < 1000 || salarioPretendido >2500 || tempoExp == "até 1 ano")
            {
                MessageBox.Show("Obrigado, mas você não preenche os requisitos necessarios para a vaga!");
            }
            else if(tempoExp == "1-2 anos")
            {
                MessageBox.Show("Futuramente você será chamado para um teste em nossa empresa!");
            }
            else
            {
                MessageBox.Show("Enviaremos os dados para a entrevista de emprego!");
            }
            ActiveControl = txtNome;
            mskbxSalario.Text = "0000.00";
            txtNome.Focus();
        }

        private void ckbxFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxFeminino.Checked == true)
            {
                ckBxMasculino.Checked = false;
            }
            else
            {
                ckBxMasculino.Checked = false;
            }
        }

        private void ckBxMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBxMasculino.Checked == true)
            {
                ckbxFeminino.Checked = false;
            }
            else
            {
                ckbxFeminino.Checked = false;
            }
        }
    }
}
