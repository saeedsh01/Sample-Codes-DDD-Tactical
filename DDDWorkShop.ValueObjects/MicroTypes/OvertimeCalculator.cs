using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.MicroTypes
{
    public class OvertimeCalculator
    {
        public OvertimeHours Calculate ( HoursWorked hoursWorked,ContractedHours contractedHours) {
            return new OvertimeHours(hoursWorked.Hours - contractedHours.Hours);
        }
    }
}
