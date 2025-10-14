


namespace EjemplosIntroductorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo1();

            //ejemplo2(args);

            ejemplo3();
        }

        private static void ejemplo3()
        {
            // Menu con while
            string opcion = "";
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Verificar versión de Windows");
                Console.WriteLine("2. Verificar versión de Office");
                Console.WriteLine("3. Parchar Windows/Office");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción (1-4): ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"Versión de Windows: {Environment.OSVersion}");
                        break;
                    case "2":
                        Console.WriteLine("Funcionalidad para verificar versión de Office no implementada.");
                        break;
                    case "3":
                        Console.WriteLine("Funcionalidad para parchar Windows/Office no implementada.");
                        break;
                    case "4":
                        // Salir
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (!opcion.Equals("4"));
            Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
        }

        private static void ejemplo2(string[] argumentos)
        {
            // Mostrar cantidad de elementos en args
            Console.WriteLine($"Cantidad de argumentos: {argumentos.Length}");
            #region Ejemplos de arreglos
            // Arreglos
            int[] numeros = { 1, 2, 3, 4, 5 };
            /*
             * [1]    [1][2][3][4][5]
             * [2]
             * [3]
             * [4]
             * [5]
             */
            Console.WriteLine($"Primer número en el arreglo: {numeros[0]}");
            Console.WriteLine($"Segudo número en el arreglo: {numeros[1]}");
            // Arreglos bidimencionales
            int[,] matriz = { { 1, 2 }, { 3, 4 } };
            /*
             [1][2]         [1][3]
             [3][4]         [2][4]
             */
            Console.WriteLine($"Elemento en la fila 1, columna 2: {matriz[0, 1]}");
            int[,] matriz2 = new int[3, 6];
            matriz2[0, 0] = 1;
            matriz2[0, 1] = 2;
            matriz2[0, 2] = 3;
            matriz2[2, 1] = 4;
            matriz2[2, 2] = 5;

            // Arreglos tridimensionales
            int[,,] cubo = new int[2, 2, 2];
            cubo[0, 0, 0] = 1;
            cubo[0, 0, 1] = 2;
            cubo[1, 1, 1] = 7;
            // Arreglos multidimensionales
            int[,,,] hipercubo = new int[2, 2, 2, 2];
            #endregion

            #region Recorrido de arreglos
            // Recorrido de arreglos
            Console.WriteLine("Recorrido del arreglo unidimensional:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            // recorriendo los argumentos
            Console.WriteLine("Recorrido de los argumentos:");
            for (int i = 0; i < argumentos.Length; i++)
            {
                Console.WriteLine(argumentos[i]);
            }
            // Recorriendo con while
            Console.WriteLine("Recorrido del arreglo unidimensional con while:");
            int j = 0;
            while (j < numeros.Length)
            {
                Console.WriteLine(numeros[j]);
                j++;
            }
            #endregion
        }

        private static void ejemplo1()
        {
            Console.WriteLine("¡Hola mundo!");

            // Tipos de datos
            int numeroEntero = 42;
            float numeroFlotante = 3.14f;
            double numeroDecimal = 3.14;
            string texto = "Hola, C#";
            bool esVerdadero = true;
            char caracter = 'c';
            Console.WriteLine("Entero: " + numeroEntero + ", Decimal: " + numeroFlotante);
            Console.WriteLine($"Entero: {numeroEntero}, Decimal: {numeroDecimal}, Texto: {texto}, Booleano: {esVerdadero}, Carácter: {caracter}");

        }
    }
}
