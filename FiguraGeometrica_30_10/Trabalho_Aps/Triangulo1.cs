using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Aps
{
    class Triangulo : FormaGeometrica
    {
        private double _base;
        private double altura;
        private double catOposto;
        private double catAdjascente;
        private double hipotenusa;

        public double CatAdjascente
        {
            get { return catAdjascente; }
            set { catAdjascente = value; }
        }

        public double CatOposto
        {
            get { return catOposto; }
            set { catOposto = value; }
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; } // Somente nesse contexto: set
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double CalcularArea()
        {
            return (_base * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
           return catAdjascente + catOposto + _base;
        }

        public double CalcularHipot()
        {
            return hipotenusa = Math.Sqrt( Math.Pow(catOposto, 2 ) + Math.Pow(catAdjascente, 2));
        }
    }
}

