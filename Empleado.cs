using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1m1_Empleados
{
    public class Empleado
    {

        private static int contadorId = 0;
        public int Id { get; private set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public decimal Salario { get; set; }
        public string? Area { get; set; }

        public Empleado() {

            Id = ++contadorId;
        }
    }
}
