using DDDWorkShop.DomainEvents.Frameworks;

namespace DDDWorkShop.DoaminEvent.CoreDomain
{
    public class PersonDeactivated : IDomainEvent
    {
        public int iD { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }

    public class Person:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public bool IsActive { get; set; }

        public void Deactivate()
        {
            this.IsActive = false;
        }

        public void Activate()
        {
            this.IsActive = true;

            AddEvent(new PersonDeactivated
            {
                iD=Id,
                Email=Email,
                Mobile=Mobile
            });
        }
    }
}
