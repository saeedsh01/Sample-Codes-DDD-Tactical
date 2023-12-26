using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class ContractedHours : BaseValueObject<ContractedHours>
    {
        public readonly Hours Hours;
        public ContractedHours(Hours hours)
        {
            this.Hours = hours;
        }

        protected override int GetHashCodeCore()
        {
            return Hours.GetHashCode();
        }

        protected override bool IsEqual(ContractedHours other)
        {
            return this.Hours == other.Hours;
        }
    }
}
