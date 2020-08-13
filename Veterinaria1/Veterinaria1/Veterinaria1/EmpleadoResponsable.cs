using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    public class EmpleadoResponsable:IEmpleado
    {
        public int EmpleadoResponsableId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Saludar(string Saludo)
        {
            return $"Muy buenos dias {Saludo} en que le puedo ayudar";
        }
        public string Atender(string TipoDeAtencion)
        {
            return $"Atender clientes lo hago con gusto{TipoDeAtencion}";
        }
        public string Cortar(string TipoDeCorte)
        {
            return $"Todos los cortes que hago, es con precaución {TipoDeCorte}";
        }
    }
}
