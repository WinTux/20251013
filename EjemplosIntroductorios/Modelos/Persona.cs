using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Persona
    {
        protected string _Nombre;
        public string Nombre 
        { 
            get { return _Nombre; } 
            set { _Nombre = value; }
        }
        protected string _Apellido;
        public string Apellido 
        { 
            get { return _Apellido; } 
            set { _Apellido = value; }
        }
        protected int _Edad;
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
        protected bool _Casado;
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

        public Persona(string apellido, string nombre) {
            _Nombre = nombre;
            _Apellido = apellido;
            _Edad = 18;
            _Casado = false;
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
    public class Empleado : Persona, ICiudadano {
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

        public string Pais { get; set; }

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

        // Acciones o métodos
        public void MostrarInformacionLaboral()
        {
            Console.WriteLine($"Soy {_Nombre} {_Apellido}, trabajo como {_cargo} y mi sueldo es {_sueldo}.");
        }

        public void Votar(string partido)
        {
            Console.WriteLine("El empleado votó por el partido: " + partido + " en las elecciones presidenciales de la nación.");
        }

        public string ObtenerNacionalidad()
        {
            return "Soy empleado y mi nacionalidad es de " + Pais;
        }
    }

    public interface ICiudadano
    {
        string Pais { get; set; }
        void Votar(string partido);
        string ObtenerNacionalidad();
    }
}
namespace Universidad {
    namespace Pregrado
    {
        public class Estudiante : ICiudadano
        {
            public int matricula { get; set; }
            public string carrera { get; set; }
            public string Pais { get; set ; }
            // Constructor con parámetros
            public Estudiante(int matricula, string carrera, string pais)
            {
                this.matricula = matricula;
                this.carrera = carrera;
                this.Pais = pais;
            }
            public string ObtenerNacionalidad()
            {
               return "Soy estudiante y mi nacionalidad es de " + Pais;
            }

            public void Votar(string partido)
            {
                Console.WriteLine("El estudiante votó por el partido: " + partido + " para su universidad.");
            }
        }
    }
    namespace Postgrado
    {
        public class Estudiante : ICiudadano
        {
            public int matricula { get; set; }
            public string carrera { get; set; }
            public string profesion { get; set; }
            public string gradoAcademico { get; set; }
            public string Pais { get; set; }
            // Constructor con parámetros
            public Estudiante(int matricula, string carrera, string profesion, string gradoAcademico)
            {
                this.matricula = matricula;
                this.carrera = carrera;
                this.profesion = profesion;
                this.gradoAcademico = gradoAcademico;
            }
            public void Votar(string partido)
            {
                Console.WriteLine("El estudiante de postgrado votó en las elecciones de su país.");
            }

            public string ObtenerNacionalidad()
            {
                return "El estudiante de postgrado es de nacionalidad desconocida.";
            }
        }
    }
}

public class Cliente : Models.Persona
{
    public int nit;
    public Cliente(string nombre, string apellido, int Edad, bool casado, int nit) 
        : base(nombre, apellido, Edad, casado)
    {
        this.nit = nit;
    }
    public Cliente() : base() {
        this.nit = 9999; 
    }
}