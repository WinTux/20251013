



namespace EjemplosIntroductorios
{
    using Models;
    using Universidad.Postgrado;
    // Usando alias en los usings
    using Est = Universidad.Pregrado.Estudiante;
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo1();

            //ejemplo2(args);

            //ejemplo3();

            ejemplo4();
        }

        private static void ejemplo4()
        {
            // Inicializando una Persona
            Persona per = new Persona();
            Persona per2 = new Persona("Pepe", "Perales", 27, true);
            Cliente c01 = new Cliente();
            Est e01 = new Est(123,"Economía","Chile");
            Estudiante e02 = new Estudiante(123,"Linguística","Admin. empresas","Licenciatura");
            Tesis t01 = new Tesis("analisis lógico");
            Herramientas.Comunes.Conversor conv = new Herramientas.Comunes.Conversor();

            // Mostrar los objetos del tipo Persona
            Console.WriteLine("Datos de las personas:");
            Console.WriteLine($"Persona 1: {per.Nombre} {per.Apellido}, Edad: {per.Edad}, Casado: {per.Casado}");
            Console.WriteLine($"Persona 2: {per2.Nombre} {per2.Apellido}, Edad: {per2.Edad}, Casado: {per2.Casado}");
            // Usando los métodos de la clase Persona
            per.Saludar();
            per2.Saludar();
            per.CumplirAnios();
            per2.CumplirAnios();

            per.Nombre = "Ana";
            per.Apellido = "García";
            per2.Apellido = "Pereira";
            per2.Edad = -30;
            per.Casado = true;
            Console.WriteLine($"Persona 1: {per.Nombre} {per.Apellido}, Edad: {per.Edad}, Casado: {per.Casado}");
            Console.WriteLine($"Persona 2: {per2.Nombre} {per2.Apellido}, Edad: {per2.Edad}, Casado: {per2.Casado}");

            Empleado emp1 = new Empleado();
            Console.WriteLine($"Empleado 1: {emp1.Nombre} {emp1.Apellido}, Edad: {emp1.Edad}, Casado: {emp1.Casado}, Cargo: {emp1.cargo}, Sueldo: {emp1.sueldo}");
            emp1.MostrarInformacionLaboral();
            emp1.CumplirAnios();
            Cliente cli1 = new Cliente("Luis", "Martínez", 35, false, 123456);
            cli1.CumplirAnios();

            #region errores
            // Error de sintaxis: Ej. falta punto y coma (;)

            // Error de tiempo de ejecución: Ej. división por cero
            //int div = 0;
            //int x = 10 / div;

            // Error semántico: Como edad -30
            #endregion

            // Arreglo de empleados
            Empleado[] empleados = new Empleado[3];
            empleados[0] = new Empleado("Carlos", "Lopez", 28, false, 2500.50, "Desarrollador");
            empleados[1] = new Empleado("María", "González", 32, true, 3000.75, "Analista");
            empleados[2] = new Empleado("Ana", "Ramírez", 26, false, 2200.00, "Diseñadora");
            Console.WriteLine("Lista de empleados:");
            foreach (Empleado emp in empleados)
            {
                string casadoTexto = emp.Casado ? "Sí" : "No";
                Console.WriteLine($"Empleado: {emp.Nombre} {emp.Apellido}, Edad: {emp.Edad}, Casado: {casadoTexto}, Cargo: {emp.cargo}, Sueldo: {emp.sueldo}");

                // Casteando a persona
                Persona p = (Persona)emp;
                p.Saludar();
                p.CumplirAnios();
                ((Empleado)p).sueldo = 6000;
            }

            // Arreglo de personas
            Persona[] personas = new Persona[5];
            personas[0] = new Persona("Luis", "Fernández", 40, true);
            personas[1] = new Empleado("Carlos", "Lopez", 28, false, 2500.50, "Desarrollador");
            personas[2] = new Cliente("Luis", "Martínez", 35, false, 123456);
            personas[3] = new Persona("Ana", "García", 30, true);
            personas[4] = new Empleado("María", "González", 32, true, 3000.75, "Analista");
            Console.WriteLine("Lista de personas:");
            foreach (Persona p in personas)
            {
                string casadoTexto = p.Casado ? "Sí" : "No";
                Console.WriteLine($"Persona: {p.Nombre} {p.Apellido}, Edad: {p.Edad}, Casado: {casadoTexto}");
            }
            Console.WriteLine("Lista de personas (tratando de mostrar su sueldo):");
            foreach (Persona pe in personas)
            {
                //Empleado p = pe as Empleado;
                //Empleado p = (Empleado)pe;
                Console.WriteLine($"Persona: {pe.Nombre} {pe.Apellido}");
            }

            #region Polimorfismo
            Console.WriteLine("Demostración de polimorfismo:");
            ICiudadano[] ciudadanos = new ICiudadano[3];
            ciudadanos[0] = new Empleado("Pedro", "Sánchez", 45, true, 4000.00, "Gerente") { Pais = "España" };
            ciudadanos[1] = new Est( 12222, "Ing. de sistemas", "Bolivia");
            ciudadanos[2] = new Estudiante( 12228, "Maestría en Ciencias", "Matemático","Licenciatura");
            foreach (ICiudadano ciudadano in ciudadanos)
            {
                Console.WriteLine($"Ciudadano de: {ciudadano.Pais}");
                Console.WriteLine($"Nacionalidad: {ciudadano.ObtenerNacionalidad()}");
                ciudadano.Votar("Partido de la Gente");
            }
            #endregion
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
                Console.WriteLine(numeros[j++]);
                //j++;
            }
            // Recorriendo con foreach
            Console.WriteLine("Recorrido del arreglo unidimensional con foreach:");
            foreach (int numero in numeros)
                Console.WriteLine(numero);
            Console.WriteLine("Fin del recorrido de arreglos");

            // Ejemplo recorriendo índices pares en un arreglo
            Console.WriteLine("Recorrido de índices pares en el arreglo:");
            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.WriteLine(numeros[i]);
                if (i == 100) // Condición que genera un bucle infinito para arreglos de 100 o más casillas.
                    i = 0;
            }
            // Tipos de incrementos
            Console.WriteLine("Incremento/Decremento postfijo:");
            int a = 5;
            Console.WriteLine(a++); // Muestra 5, luego a es 6
            Console.WriteLine(a);   // Muestra 6
            Console.WriteLine(a--); // Muestra 6, luego a es 5
            Console.WriteLine(a);   // Muestra 5
            Console.WriteLine("Incremento/Decremento prefijo:");
            int b = 5;
            Console.WriteLine(++b); // Primero incrementa b a 6, luego muestra 6
            Console.WriteLine(b);   // Muestra 6
            Console.WriteLine(--b); // Primero decrementa b a 5, luego muestra 5
            Console.WriteLine(b);   // Muestra 5
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

namespace Herramientas.Comunes { 
    public class Conversor
    {
        public static int ConvertirAEntero(string valor)
        {
            return int.Parse(valor);
        }
    }
}
namespace Universidad {
    namespace Postgrado { 
        public class Tesis
        {
            public string titulo { get; set; }
            public int anio { get; set; }
            public Tesis(string titulo)
            {
                this.titulo = titulo;
                this.anio = DateTime.Now.Year;
            }
            public Tesis() {
                titulo = "NO DEFINIDO";
                anio = DateTime.Now.Year;
            }
        }
    }
}