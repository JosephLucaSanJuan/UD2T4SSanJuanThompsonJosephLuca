using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4SanJuanThompsonJosephLuca
{
    internal class Triangulo:Figura
    {
        private float alt;
        private float b;

        public Triangulo(float alt, float b)
        {
            Alt = alt;
            B = b;
        }

        private float Alt { get { return alt; } set { value = alt; } }

        private float B { get { return b; } set { value = b; } }

        public override float Perimetro()
        {
            float perimetro = b+b+b;
            return perimetro;
        }

        public override float Area()
        {
            float area = (b*alt)/2;
            return area;
        }
    }
}
