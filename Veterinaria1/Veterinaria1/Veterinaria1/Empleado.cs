using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    public class Empleado:IEmpleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Saludar(string Saludo)
        {
            return $"Muy buenos dias {Saludo}";
        }
        public string Atender(string TipoDeAtencion)
        {
            return $"Atender clientes es mi pasión {TipoDeAtencion}";
        }
        public string Cortar(string TipoDeCorte)
        {
            return $"Los cortes mas solicitados son {TipoDeCorte}";
        }

    }
}
