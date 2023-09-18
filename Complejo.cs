using System;
namespace FormComplejosGRAJ_G2
{
    internal class Complejo
    {
        #region Atributos

        private float real;
        private float imaginaria;

        #endregion

        #region Metodos

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria=imaginaria;

        }

        public static Complejo operator +(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo(c1.real+c2.real,c1.imaginaria+c2.imaginaria);
            return c3;
        }

        public static Complejo operator -(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo(c1.real - c2.real, c1.imaginaria - c2.imaginaria);
            return c3;
        }

        public static Complejo operator *(Complejo c1, Complejo c2)
        {
            Complejo c3 = new Complejo((c1.real*c2.real)-(c1.imaginaria*c2.imaginaria), (c1.real*c2.imaginaria) + (c1.imaginaria*c2.real));
            return c3;
        }


        public static Complejo operator ~(Complejo c)
        {
            Complejo cReal = new Complejo(c.real,-c.imaginaria);
            return cReal;
        }



        public override string ToString()
        {
            if (imaginaria >= 0)
                return String.Format("{0} + {1}i", real, imaginaria);
            else
                return String.Format("{0} {1}i", real, imaginaria);
        }

        #endregion 

    }
}
