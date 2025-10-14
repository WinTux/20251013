namespace EjemplosIntroductorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola mundo!");

            // Tipos de datos
            int numeroEntero = 42;
            float numeroFlotante = 3.14f;
            double numeroDecimal = 3.14;
            string texto = "Hola, C#";
            bool esVerdadero = true;
            char caracter = 'c';
            Console.WriteLine("Entero: "+numeroEntero+", Decimal: "+ numeroFlotante);
            Console.WriteLine($"Entero: {numeroEntero}, Decimal: {numeroDecimal}, Texto: {texto}, Booleano: {esVerdadero}, Carácter: {caracter}");
        }
    }
}
