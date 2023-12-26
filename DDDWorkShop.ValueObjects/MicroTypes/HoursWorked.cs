using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class HoursWorked : BaseValueObject<HoursWorked>
    {
        public readonly Hours Hours;
        public HoursWorked(Hours hourWorked)
        {
            this.Hours = hourWorked;
        }

        protected override int GetHashCodeCore()
        {
            return this.Hours.GetHashCode();
        }

        protected override bool IsEqual(HoursWorked other)
        {
            return this.Hours == other.Hours;
        }
    }
}
