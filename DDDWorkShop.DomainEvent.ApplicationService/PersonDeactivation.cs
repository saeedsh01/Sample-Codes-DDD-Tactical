using DDDWorkShop.DoaminEvent.CoreDomain;
using DDDWorkShop.DomainEvents.Frameworks;

namespace DDDWorkShop.DomainEvent.ApplicationService
{
    public partial class PersonDeactivation
    {
        private readonly  IPersonRepository personRepository;
        private readonly  IEventDispatcher _eventDispatcher;
        public PersonDeactivation(IPersonRepository personRepository, IEventDispatcher eventDispatcher)
        {
            this.personRepository = personRepository;
            _eventDispatcher = eventDispatcher;
        }

        public void Execute(int personId)
        {
             var person = personRepository.Get(personId);
            person.Deactivate();
            _eventDispatcher.Dispatche(person.Events.ToArray());
        }
    }
}
