using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.Moneyv2
{
    public class Money : BaseValueObject<Money>
    {
        private readonly decimal Value;

        public Money(decimal value)
        {
            Value = value;
        }
        public Money() : this(0m)
        {

        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        protected override bool IsEqual(Money other)
        {
            return Value == other.Value;
        }
    }
}
