using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.DomainEvents.Framworks
{
    public interface IEventHandler<in T> where T : IDomainEvent
    {
        void Handle(T @event);
    }
}
