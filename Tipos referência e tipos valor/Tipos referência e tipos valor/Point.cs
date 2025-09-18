using System;


namespace Tipos_referência_e_tipos_valor
{
   struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
