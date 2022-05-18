using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            float promedio = 0;

            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
            nota3 = int.Parse(txtNota3.Text);
            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio > 7)
            {
                MessageBox.Show("Promocionaste tu nota es un " + promedio);
            }
            if (promedio > 4 && promedio < 7)
            {
                MessageBox.Show("Aprobaste tu nota es un " + promedio);
            }
            if (promedio < 4)
            {
                MessageBox.Show("No aprobaste tu nota es un " + promedio);
            }
        }
    }
}
