namespace DDDWorkShop.DomainEvents.CoreDomain
{
    public interface PersonRepository
    {
        Person Get(int id);
        List<Person> GetAll();
    }
}
