using DDDWorkShop.DomainEvents.Framworks;

namespace DDDWorkShop.DomainEvents.CoreDomain
{
     public class personDeactivated : IDomainEvent
    {
        public int Id { get; set; }
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
        public bool IsActive {  get; set; }

        public void Deactivate()
        {
            IsActive = false;
            AddEvent(new personDeactivated 
            { 
                Id = Id,
                Email = Email,
                Mobile = Mobile
            });
        }
    }


}
