using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;
using System;

namespace PropertyRental.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        public void Save(Property property)
        {
            // Simulación de guardado en base de datos
            Console.WriteLine($"Propiedad en {property.Address} guardada con éxito.");
        }
    }
}
