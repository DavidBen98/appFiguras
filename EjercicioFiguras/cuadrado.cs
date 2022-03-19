using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    class Cuadrado:Rectangulo
    {
        #region atributos
        private double lado;
        #endregion

        #region propiedades
        public double LADO
        {
            get
            {
                return lado;
            }
            set
            {
                if (esValido(value))
                    lado = value;
            }
        }
        #endregion

        #region consultas
        public override double Area()
        {
            return (lado * lado);
        }
        public override double Perimetro()
        {
            return (4 * lado);
        }
        public override string ToString()
        {
            return $"Lado: {lado.ToString()} cm";
        }
        public override bool Equals(Object obj)
        {
            bool igual;
            if (obj == null)
                igual = (this == null);
            else if (this.GetType() != obj.GetType())
                igual = false;
            else
            {
                Cuadrado c = (Cuadrado)obj;
                igual = (this.lado == c.lado);
            }
            return igual;
        }
        #endregion

        #region estaticos
        public static double lado_inicial = 0;
        public static bool esValido(double LADO)
        {
            return ((LADO > 0) && (LADO <= 1000));
        }
        #endregion

        #region constructor
        public Cuadrado(double LADO):base(LADO,LADO)
        {
            if (esValido(LADO))
                this.lado = LADO;
            else
                this.lado = 0;
        }
        #endregion
    }
}