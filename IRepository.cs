using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1m1_Empleados
{
    public interface IRepository 
    {
        void Serialize<T>(T entity, string filename);
        T Deserialize<T>(string filename);
        Task<decimal> CalcularSalarios<T>(List<T> empleados) where T :Empleado;
    }
}
