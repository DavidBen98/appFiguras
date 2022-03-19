using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    class Circulo : Figura
    {
        #region atributos
        private double radio;
        #endregion

        #region propiedades
        public double RADIO
        {
            get
            {
                return radio;
            }
            set
            {
                if (esValido(value))
                    radio = value;
            }
        }
        #endregion

        #region consultas
        public override double Area()
        {
            return (3.1416 * (Math.Pow(radio, 2)));
        }
        public override double Perimetro()
        {
            return (3.1416 * 2 * radio);
        }
        public override string ToString()
        {
            return $"Radio: {radio.ToString()} cm";
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
                Circulo p = (Circulo)obj;
                igual = (this.radio == p.radio);
            }
            return igual;
        }
        #endregion

        #region estaticos
        public static bool esValido(double radio)
        {
            return (radio > 0);
        }
        #endregion

        #region constructor
        public Circulo(double radio)
        {
            if (esValido(radio))
                this.radio = radio;
            else
                this.radio = 0;
        }
        #endregion
    }
}