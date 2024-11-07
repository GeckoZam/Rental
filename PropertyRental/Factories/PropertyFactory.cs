using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Factories
{
    public class PropertyFactory
    {
        public Property CreateProperty(string address, int pricePerNight, string ownerId)
        {
            return new Property
            {
                Address = address,
                PricePerNight = pricePerNight,
                OwnerId = ownerId
            };
        }
    }
}
