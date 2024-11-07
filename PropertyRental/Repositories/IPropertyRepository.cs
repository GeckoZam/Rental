using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Repositories
{
    public interface IPropertyRepository
    {
        void Save(Property property);
    }
}
