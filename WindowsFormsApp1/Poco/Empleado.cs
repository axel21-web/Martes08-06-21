using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Poco
{
    class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public Profesion Profesion { get; set; }
        public Cargo Cargo { get; set; }
        public double Salario { get; set; }
    }
}
