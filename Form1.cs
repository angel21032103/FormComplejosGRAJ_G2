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
        public  int Verificador = 0;

        #endregion


        public Calculadora_Complejos_Marca_GIL()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtbReal1.Text == "")
                {
                    Verificador = 1;
                    throw new ApplicationException("La parte real del complejo uno no debe estar vacia");

                }

                if (txtbReal2.Text == "")
                {
                    Verificador = 2;

                    throw new ApplicationException("La parte real del complejo dos no debe estar vacia");

                }

                if (txtbImaginaria1.Text == "")
                {
                    Verificador = 3;

                    throw new ApplicationException("La parte imaginaria del complejo uno no debe estar vacia");

                }

                if (txtbImaginaria2.Text == "")
                {
                    Verificador = 4;

                    throw new ApplicationException("La parte imaginaria del complejo dos no debe estar vacia");

                }



                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

                c3 = c1 + c2;
                lbSuma.Text = c3.ToString();
                errorProvider1.Clear();
                Verificador = 0;

            }
            catch(ApplicationException error)
            {
                switch (Verificador)
                {
                    case 1:
                        errorProvider1.SetError(txtbReal1, error.Message);

                        break;

                    case 2:
                        errorProvider1.SetError(txtbReal2, error.Message);

                        break;

                    case 3:
                        errorProvider1.SetError(txtbImaginaria1, error.Message);

                        break;

                    case 4:
                        errorProvider1.SetError(txtbImaginaria2, error.Message);

                        break;

                    default:
                        break;

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Debes de ingresar un número ");
            }
            catch(Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
            }
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


            try
            {

                if (txtbReal1.Text == "")
                {
                    Verificador = 1;
                    throw new ApplicationException("La parte real del complejo uno no debe estar vacia");
                    
                }

                if (txtbReal2.Text == "")
                {
                    Verificador = 2;

                    throw new ApplicationException("La parte real del complejo dos no debe estar vacia");

                }

                if (txtbImaginaria1.Text == "")
                {
                    Verificador = 3;

                    throw new ApplicationException("La parte imaginaria del complejo uno no debe estar vacia");

                }

                if (txtbImaginaria2.Text == "")
                {
                    Verificador = 4;

                    throw new ApplicationException("La parte imaginaria del complejo dos no debe estar vacia");

                }


                c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginaria1.Text));
                c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginaria2.Text));

                c3 = c1 * c2;
                lbSuma.Text = c3.ToString();
                errorProvider1.Clear();
                Verificador = 0;
             
            }

            catch (ApplicationException error)
            {
                switch(Verificador)
                {
                    case 1:
                        errorProvider1.SetError(txtbReal1, error.Message);

                        break;

                    case 2:
                        errorProvider1.SetError(txtbReal2, error.Message);

                        break;

                    case 3:
                        errorProvider1.SetError(txtbImaginaria1, error.Message);

                        break;

                    case 4:
                        errorProvider1.SetError(txtbImaginaria2, error.Message);

                        break;

                    default:
                        break;

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Debes de ingresar un número ");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

        }

        private void btnConjugar_Click(object sender, EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }


    }
}
