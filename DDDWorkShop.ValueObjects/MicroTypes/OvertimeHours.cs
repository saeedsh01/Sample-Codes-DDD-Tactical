using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class OvertimeHours : BaseValueObject<OvertimeHours>
    {
        private readonly Hours Hours;
        public OvertimeHours(Hours hours)
        {
            this.Hours = hours;
        }

        protected override int GetHashCodeCore()
        {
            return this.Hours.GetHashCode();
        }

        protected override bool IsEqual(OvertimeHours other)
        {
            return this.Hours == other.Hours;
        }
    }
}
