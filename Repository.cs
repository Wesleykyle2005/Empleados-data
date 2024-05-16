using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Examen1m1_Empleados
{
    public class Repository : IRepository
    {          
        public void Serialize<T>(T entity, string filename)
        {
            string json = JsonConvert.SerializeObject(entity , Formatting.Indented);
            File.WriteAllText(filename, json);          
        }
        public T Deserialize<T>(string filename)
        {
            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(json);
        }
        public Task<decimal> CalcularSalarios<T>(List<T> empleados) where T : Empleado
        {
            return Task.Run(() =>
            {
                decimal total = empleados.Sum(emp => emp.Salario);
                return total;
            });
        }
    }
}
