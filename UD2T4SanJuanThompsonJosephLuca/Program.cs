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
                        salir = true;
                        break;

                    case 2:
                        salir = true;
                        break;

                    case 3:
                        salir = true;
                        break;
                }
            }
        }
    }
}