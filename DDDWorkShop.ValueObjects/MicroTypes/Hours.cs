using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class Hours : BaseValueObject<Hours>
    {
        public readonly int Amount;
        public Hours(int amount)
        {
            this.Amount = amount;
        }

        public static Hours operator -(Hours left, Hours right)
        {
            return new Hours(left.Amount - right.Amount);
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }

        protected override bool IsEqual(Hours other)
        {
            throw new NotImplementedException();
        }
    }
}
