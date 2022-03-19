using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    class Triangulo:Figura
    {
        #region atributos
        private double baseTriangulo;
        private double altura;
        private double ladoUno;
        private double ladoDos;
        #endregion

        #region propiedades
        public double BASE
        {
            get
            {
                return baseTriangulo;
            }
            set
            {
                if (esValido(value, altura,ladoUno,ladoDos))
                    baseTriangulo = value;
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
                if (esValido(baseTriangulo, value,ladoUno,ladoDos))
                    altura = value;
            }
        }
        public double LADOUNO
        {
            get
            {
                return ladoUno;
            }
            set
            {
                if (esValido(baseTriangulo,altura,value,ladoDos))
                    ladoUno = value;
            }
        }
        public double LADODOS
        {
            get
            {
                return ladoDos;
            }
            set
            {
                if (esValido(baseTriangulo, altura,ladoUno,value))
                    ladoDos = value;
            }
        }
        #endregion

        #region consultas
        public override double Area()
        {
            return ((baseTriangulo * altura)/2);
        }
        public override double Perimetro()
        {
            return (baseTriangulo + ladoUno + ladoDos);
        }
        public override string ToString()
        {
            return $"Base: {baseTriangulo.ToString()} cm - Altura: {altura.ToString()} cm - Lado uno: {ladoUno.ToString()} - Lado dos: {ladoDos.ToString()}";
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
                Triangulo t = (Triangulo)obj;
                igual = (this.baseTriangulo == t.BASE && this.altura == t.ALTURA && this.ladoUno == t.LADOUNO && this.ladoDos == t.ladoDos);
            }
            return igual;
        }
        #endregion

        #region estaticos
        public static double base_inicial = 0;
        public static double altura_inicial = 0;
        public static bool esValido(double baseT, double altura,double ladoUno,double ladoDos)
        {
            return ((baseT > 0) && (baseT <= 1000) && (altura > 0) && (altura <= 1000) && (ladoUno>0) && (ladoUno <= 1000) && (ladoDos>0) && (ladoDos<=1000));
        }
        #endregion

        #region constructor
        public Triangulo(double baseTriangulo, double altura,double ladoUno,double ladoDos)
        {
            if (esValido(baseTriangulo, altura, ladoUno, ladoDos))
            {
                this.baseTriangulo = baseTriangulo;
                this.altura = altura;
                this.ladoUno = ladoUno;
                this.ladoDos = ladoDos;
            }
            else
            {
                this.baseTriangulo = 0;
                this.altura = 0;
                this.ladoUno = 0;
                this.ladoDos = 0;
            }
        }
        #endregion
    }
}