using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4SanJuanThompsonJosephLuca
{
    internal class Circulo:Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            Radio = radio;
        }

        private float Radio { get {  return radio; } set { radio = value;} }

        public override float Perimetro()
        {
            float perimetro = 2 * (float)3.14 * radio;
            return perimetro;
        }

        public override float Area()
        {
            float area = (float)3.14*(radio*radio);
            return area;
        }
    }
}
