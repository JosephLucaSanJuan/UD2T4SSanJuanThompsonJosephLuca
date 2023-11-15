namespace UD2T4SanJuanThompsonJosephLuca
{
    abstract class Figura
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

        public abstract float Perimetro();

        public abstract float Area();
    }
}