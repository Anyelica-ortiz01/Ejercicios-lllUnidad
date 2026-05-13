using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados.Modelos
{
    public class Empleado
    { 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
    }
}
