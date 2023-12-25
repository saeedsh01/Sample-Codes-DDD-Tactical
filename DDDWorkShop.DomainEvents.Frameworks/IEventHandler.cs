using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.DomainEvents.Frameworks
{
    internal interface IEventHandler<in T> where T : IDomainEvent
    {
        void Handle(T @entity); 
    }
}
