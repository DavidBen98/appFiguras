using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFiguras
{
    abstract class Figura
    {
        #region consultas
        public abstract double Area();
        public abstract double Perimetro();
        #endregion
    }
}