using System;
using System.Windows.Forms;

namespace FormComplejosGRAJ_G2
{
    public partial class Calculadora_Complejos_Marca_GIL : Form
    {
        #region Atributos
        Complejo c1;
        Complejo c2;
        Complejo c3;

        #endregion


        public Calculadora_Complejos_Marca_GIL()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

            c3 = c1 + c2;
            lbSuma.Text = c3.ToString();
        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

            c3 = c1 - c2;
            lbSuma.Text = c3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

            c3 = c1 * c2;
            lbSuma.Text = c3.ToString();
        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }


    }
}
