using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4SanJuanThompsonJosephLuca
{
    internal class Rectangulo:Figura
    {
        private int lado1;
        private int lado2;

        public Rectangulo(int lado1, int lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        private int Lado1 {  get {  return lado1; } set {  lado1 = value; } }

        private int Lado2 {  get {  return lado2; } set {  lado2 = value; } }

        public override float Perimetro()
        {
            float perimetro = lado1 * 2 + lado2 * 2;
            return perimetro;
        }

        public override float Area()
        {
            float area = lado1*lado2;
            return area;
        }
    }
}
