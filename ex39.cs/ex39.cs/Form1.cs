using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex39.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            {
                Random rnd = new Random();

                int[] a = new int[10];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rnd.Next(0, 100);
                }


                int[] b = new int[10];
                for (int i = 0; i < b.Length; i++)
                {
                    if (i % 2 == 0)
                        b[i] = rnd.Next(0, 100) * 5;
                    else
                        b[i] = rnd.Next(0, 100) + 5;

                }
                string matriz1 = String.Join(", ", a.Select(p => p.ToString()).ToArray());
                string matriz2 = String.Join(", ", b.Select(p => p.ToString()).ToArray());
                MessageBox.Show("Matriz 1 = " + matriz1 + "\nMatriz 2 = " + matriz2);
            }
        }
    }
}
