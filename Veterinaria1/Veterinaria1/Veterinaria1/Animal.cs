using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria1
{
    class Animal
    {
        public int AnimalId { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<ClienteAnimal> ClienteAnimals { get; set; } = new List<ClienteAnimal>();
        public string Caminar() 
        {
            return $"Puedo caminar";
        }
    }
}
