using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.DomainEvents.Frameworks
{
    public internal interface IDomainEvent
    {

    }
    public class BaseEntity
    {
        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();
        public IEnumerable<IDomainEvent> Events
        {
            get
            {
                return _events;
            }
        }

        protected void AddEvent(IDomainEvent @event)
        {
            _events.Add(@event);
        }
        protected void ClearEvents()
        {
            _events.Clear();
        }
    }
}
