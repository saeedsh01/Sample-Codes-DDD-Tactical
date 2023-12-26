using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.FactoryMethodSample
{
    public class FullName : BaseValueObject<FullName>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public static FullName Create(string firstName, string lastName)
        {
            Validate(firstName, lastName);
            return new FullName
            {
                FirstName = firstName,
                LastName = lastName
            };

        }

        private static void Validate(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new FirstNameIsRequird();
            if (string.IsNullOrEmpty(lastName))
                throw new LastNameIsRequird();
        }

        public static FullName CreateChekLenght(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new FirstNameIsRequird();
            if (string.IsNullOrEmpty(lastName))
                throw new LastNameIsRequird();
            if (firstName.Length < 2)
                throw new FirstNameLenghtIsInvalid();
            if (lastName.Length < 2)
                throw new LastNameLenghtIsInvalid();
            return new FullName
            {
                FirstName = firstName,
                LastName = lastName
            };

        }
        private FullName() { }
        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        protected override bool IsEqual(FullName other)
        {
            throw new NotImplementedException();
        }
    }
}
