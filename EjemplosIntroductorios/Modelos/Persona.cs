using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }

    }
    public class Empleado { 
        public double sueldo { get; set; }
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