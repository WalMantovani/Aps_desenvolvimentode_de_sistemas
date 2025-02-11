﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Aps
{
    class Circunferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; } // Somente nesse contexto: set
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public override double CalcularPerimetro()
        {
              return 2 / Math.PI * raio;
        }
    }
}
