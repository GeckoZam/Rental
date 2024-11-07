using Microsoft.AspNetCore.Mvc;
using PropertyRental.Factories;
using PropertyRental.Repositories;
using PropertyRental.Services;

namespace PropertyRental.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly NotificationService _notificationService;
        private readonly PropertyFactory _propertyFactory;

        public PropertiesController(IPropertyRepository propertyRepository, NotificationService notificationService, PropertyFactory propertyFactory)
        {
            _propertyRepository = propertyRepository;
            _notificationService = notificationService;
            _propertyFactory = propertyFactory;
        }

        public IActionResult CreateProperty(string address, int pricePerNight, string ownerId)
        {
            if (string.IsNullOrWhiteSpace(address))
                return BadRequest("La dirección es requerida.");

            var property = _propertyFactory.CreateProperty(address, pricePerNight, ownerId);
            _propertyRepository.Save(property);
            _notificationService.NotifyOwner(ownerId, "Su propiedad ha sido creada exitosamente");

            return Ok("Propiedad creada.");
        }
    }
}
