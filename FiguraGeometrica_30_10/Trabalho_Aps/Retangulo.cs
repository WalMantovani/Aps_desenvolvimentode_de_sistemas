namespace Trabalho_Aps
{
    class Retangulo : FormaGeometrica
    {
        private double rbase;
        private double altura;

        public double Base
        {
            get { return rbase; }
            set { rbase = value; } // Somente nesse contexto: set
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; } // Somente nesse contexto: set
        }

        public override double CalcularArea()
        {
            return rbase * altura;
        }

        public override double CalcularPerimetro()
        {
            return (rbase * 2) + (altura * 2);
        }

    }
}
