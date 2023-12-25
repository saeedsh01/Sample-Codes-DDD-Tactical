namespace DDDWorkShop.DoaminEvent.CoreDomain
{
    public class FakePersonRepository : IPersonRepository
    {
        private static List<Person> people = new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName="Alireza",
                LastName="Oromand",
                Email="ar.oroumand@gmail.com",
                IsActive=true
            },
            new Person
            {
                Id = 2,
                FirstName="Saeed",
                LastName="Shirvani",
                Email="s.Shirva@gmail.com",
                IsActive=true
            },
        };

        public Person Get(int id)
        {
            return people.FirstOrDefault(x => x.Id == id);
        }
    }
}
