using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    class Gato:Animal
    {
        public string Maullar()
        {
            return $"Puedo maullar fuerte";
        }
        public string Aruñar()
        {
            return $"Me gusta aruñar los brazos";
        }
        public string Raspar()
        {
            return $"Me gusta raspar los muebles";
        }
    }
}
