using DDDWorkShop.DomainEvents.CoreDomain;
using DDDWorkShop.DomainEvents.Framworks;

namespace DDDWorkShop.DomainEvents.ApplicationService
{
    public class PersonDeactivation
    {
        private readonly PersonRepository personRepository;
        private readonly IEventDispatcher _eventDispatcher;
        public PersonDeactivation(PersonRepository personRepository, IEventDispatcher eventDispatcher)
        {
            this.personRepository = personRepository;
            this._eventDispatcher = eventDispatcher;
        }
        public void Execute(int personId)
        {
            var person = personRepository.Get(personId);
            person.Deactivate();
            _eventDispatcher.Dispatche(person.Events.ToArray());
            //Send Email
            //Send SMS
        }

    }
}
