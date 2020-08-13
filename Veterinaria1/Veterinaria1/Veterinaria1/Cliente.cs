using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public List<ClienteAnimal> ClienteAnimals { get; set; } = new List<ClienteAnimal>();
        public string Saludar()
        {
            return $"Muy buenos dias";
        }
        public string Informacion()
        {
            return $"Mi nombre es:{Nombre}, mi apellido es{Apellido}, mi numero de cedula es{Cedula},Mi numero de telefono es{Telefono}";
        }
        public string Comprar()
        {
            return $"Compra";
        }
    }
}
