namespace UD2T4SanJuanThompsonJosephLuca

///////////////////////////////////////////
// Tarea: UD2T4
// Alumno: Joseph Luca San Juan Thompson
// Curso: 2022/2023
///////////////////////////////////////////
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Boolean salir = false;
            Figura fig;
            float p = 0;
            float a = 0;

            while (!salir)
            {
                Console.WriteLine("-MENÚ PRINCIPAL-");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Rectángulo");
                Console.WriteLine("2 - Círculo");
                Console.WriteLine("3 . Triángulo");
                Console.WriteLine("Introduzca su opción:");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        salir = true;
                        break;

                    case 1:
                        Console.WriteLine("Introduce el lado largo");
                        int ladoG = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el lado pequeño");
                        int ladop = int.Parse(Console.ReadLine());
                        fig = new Rectangulo(ladoG, ladop);
                        p = fig.Perimetro();
                        a = fig.Area();
                        Console.WriteLine($"El perimetro de la figura es {p} y el area es {a}");
                        salir = false;
                        break;

                    case 2:
                        Console.WriteLine("Introduce el radio");
                        int radio = int.Parse(Console.ReadLine());
                        fig = new Circulo(radio);
                        p = fig.Perimetro();
                        a = fig.Area();
                        Console.WriteLine($"El perimetro de la figura es {p} y el area es {a}");
                        salir = false;
                        break;

                    case 3:
                        Console.WriteLine("Introduce la base");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura");
                        int h = int.Parse(Console.ReadLine());
                        fig = new Triangulo(h,b);
                        p = fig.Perimetro();
                        a = fig.Area();
                        Console.WriteLine($"El perimetro de la figura es {p} y el area es {a}");
                        salir = false;
                        break;
                }
            }
        }
    }
}