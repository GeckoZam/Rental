using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Services
{
    public class NotificationService
    {
        public void NotifyOwner(string ownerId, string message)
        {
            Console.WriteLine($"Notificación para {ownerId}: {message}");
        }
    }
}
