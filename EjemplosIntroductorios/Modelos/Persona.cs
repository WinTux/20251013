using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Persona
    {
        private string _Nombre;
        public string Nombre 
        { 
            get { return _Nombre; } 
            set { _Nombre = value; }
        }
        private string _Apellido;
        public string Apellido 
        { 
            get { return _Apellido; } 
            set { _Apellido = value; }
        }
        private int _Edad;
        public int Edad 
        { 
            get { return _Edad; } 
            set 
            { 
                if (value >= 0 && value < 150) 
                    _Edad = value; 
                else 
                    Console.WriteLine("La edad no puede ser negativa o mayor a 150."); 
            }
        }
        private bool _Casado;
        public bool Casado 
        { 
            get { return _Casado; } 
            set { _Casado = value; }
        }
        // Constructor por defecto
        public Persona() {
            _Nombre = "NN";
            _Apellido = "NN";
            _Edad = 18;
            _Casado = false;
        }
        // Constructor con parámetros
        public Persona(string nombre, string apellido, int Edad, bool casado)
        {
            _Nombre = nombre;
            _Apellido = apellido;
            this._Edad = Edad;
            _Casado = casado;
        }
        // Acciones o métodos
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {_Nombre} {_Apellido}, tengo {_Edad} años.");
        }
        public void CumplirAnios()
        {
            Console.WriteLine($"¡Feliz cumpleaños {_Nombre}! Ahora tienes {++_Edad} años.");
        }
    }
    public class Empleado : Persona {
        private double _sueldo;
        public double sueldo 
        { 
            get { return _sueldo; } 
            set 
            { 
                if (value >= 0) 
                    _sueldo = value; 
                else 
                    Console.WriteLine("El sueldo no puede ser negativo."); 
            }
        }
        private string _cargo;
        public string cargo 
        { 
            get { return _cargo; } 
            set { _cargo = value; }
        }
        // Constructor por defecto
        public Empleado() : base() {
            _sueldo = 0;
            _cargo = "NN";
        }
        // Constructor con parámetros
        public Empleado(string nombre, string apellido, int Edad, bool casado, double sueldo, string cargo) 
            : base(nombre, apellido, Edad, casado)
        {
            this._sueldo = sueldo;
            this._cargo = cargo;
        }
    }


}
namespace Universidad {
    namespace Pregrado
    {
        public class Estudiante
        {
            public int matricula { get; set; }
            public string carrera { get; set; }
        }
    }
    namespace Postgrado
    {
        public class Estudiante
        {
            public int matricula { get; set; }
            public string carrera { get; set; }
            public string profesion { get; set; }
            public string gradoAcademico { get; set; }
        }
    }
}

public class Cliente
{
    public int nit;
}