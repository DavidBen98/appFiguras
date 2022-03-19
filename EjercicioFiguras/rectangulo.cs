using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    class Rectangulo : Figura
    {
        #region atributos
        private double baseRectangulo;
        private double altura;
        #endregion

        #region propiedades
        public double BASE
        {
            get
            {
                return baseRectangulo;
            }
            set
            {
                if (esValido(value, altura))
                    baseRectangulo = value;
            }
        }
        public double ALTURA
        {
            get
            {
                return altura;
            }
            set
            {
                if (esValido(baseRectangulo, value))
                    altura = value;
            }
        }
        #endregion

        #region consultas
        public override double Area()
        {
            return (baseRectangulo * altura);
        }
        public override double Perimetro()
        {
            return (2 * baseRectangulo + 2 * altura);
        }
        public override string ToString()
        {
            return $"Base: {baseRectangulo.ToString()} cm - Altura: {altura.ToString()} cm";
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
                Rectangulo r = (Rectangulo)obj;
                igual = (this.baseRectangulo == r.baseRectangulo && this.altura == r.altura);
            }
            return igual;
        }

        #endregion

        #region estaticos
        public static double base_inicial = 0;
        public static double altura_inicial = 0;
        public static bool esValido(double baseR, double altura)
        {
            return ((baseR > 0) && (baseR <= 1000) && (altura > 0) && (altura <= 1000));
        }
        #endregion

        #region constructor
        public Rectangulo(double baseRectangulo, double altura)
        {
            if (esValido(baseRectangulo, altura))
            {
                this.baseRectangulo = baseRectangulo;
                this.altura = altura;
            }
            else
            {
                this.baseRectangulo = 0;
                this.altura = 0;
            }
        }
        #endregion
    }
}