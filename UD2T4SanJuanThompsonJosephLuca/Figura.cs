namespace UD2T4SanJuanThompsonJosephLuca
{
    internal class Figura
    {
        /*private float perimetro;
        private float area;

        public Figura(int perimetro, int area)
        {
            Perimetro = perimetro;
            Area = area;
        }

        public float Perimetro
        {
            get { return perimetro; } set { perimetro = value; }
        }

        public float Area
        {
            get { return area; } set { area = value; }
        }*/

        public virtual float Perimetro()
        {
            float perimetro = 0;
            return perimetro; 
        }

        public virtual float Area()
        {
            float area = 0;
            return area; 
        }
    }
}