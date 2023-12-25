using DDDWorkShop.DomainEvents.CoreDomain;
using DDDWorkShop.DomainEvents.Framworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.DomainEvents.ApplicationService
{
    public class SendEmailPersonDeactivatedHandler:IEventHandler<personDeactivated>
    {
        public void Handle(personDeactivated @event)
        {
            Console.WriteLine("Email for Send");
            Console.WriteLine($"Dear personId: {@event.Id}");
            Console.WriteLine("You are deactivated");
            Console.WriteLine("---------------------End of Email---------------------");

        }
    }
}
