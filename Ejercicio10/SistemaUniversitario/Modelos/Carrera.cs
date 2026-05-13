using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario.Modelos
{
    public class Carrera
    {
        public int Id { get; set; }
        public string NombreCarrera { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}
