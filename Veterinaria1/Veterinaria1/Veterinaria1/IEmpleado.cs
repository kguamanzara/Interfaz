using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    interface IEmpleado
    {
        public string Saludar(string Saludo);


        public string Atender(string TipoDeAtencion);


        public string Cortar(string TipoDeCorte);
       
    }
}
