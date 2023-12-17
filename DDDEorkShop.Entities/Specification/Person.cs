using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.Specification
{/// <summary>
/// با ساتفاده از پترن Specification  تستی جهت  بزرگ سال بودن شخص پیاده سازی شده است.
/// </summary>
    public class Person
    {
        public IsGraterThanOrEqualAgePerson IsAdult { get; set; } = new IsGraterThanOrEqualAgePerson(18);
        public int Id { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public Person(int id, DateTime birthDate)
        {
            Id = id;
            BirthDate = birthDate;
        }
        public bool AllowAdultAccess()
        {
            return IsAdult.IsSatisfiedBy(this);
        }


        public class IsGraterThanOrEqualAgePerson : ISpecification<Person>
        {
            private readonly int minValidDate;
            public IsGraterThanOrEqualAgePerson(int minValidDate)
            {

                this.minValidDate = minValidDate;
            }
            public bool IsSatisfiedBy(Person Entity)
            {
                var age = (DateTime.Now - Entity.BirthDate).TotalDays % 365;
                return age >= minValidDate;
            }
        }
    }
}
