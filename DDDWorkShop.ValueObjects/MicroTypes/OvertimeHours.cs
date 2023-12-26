using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class OvertimeHours : BaseValueObject<OvertimeHours>
    {
        public readonly Hours Hours;
        public OvertimeHours(Hours hours)
        {
            if (hours.Amount > 60)
            {
                hours = new Hours(60);
            }

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
