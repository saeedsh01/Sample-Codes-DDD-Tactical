namespace DDDWorkShop.DomainEvents.CoreDomain
{
    public class FakePersonRepository : PersonRepository
    {
        private static List<Person> people = new List<Person>
        {
            new Person
            {
                Id = 1,
                 FirstName="Alireza"  ,
                 LastName="Oroumand",
                 Email="ar.oro@gmail.com",
                 Mobile="23423423423",
                 IsActive=true,
        
            },
            new Person
            {
                Id = 2,
                 FirstName="saeed"  ,
                 LastName="Shirvani",
                 Email="saeed@gmail.com",
                 Mobile="22222222",
                 IsActive=true,

            }
        };
        public Person Get(int id)
        {
            return people.FirstOrDefault(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return people;
        }
    }
}
