using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.StatePattern
{
    public interface TvPowerAction
    {
        string Status();
    }
    public class OnStatus : TvPowerAction
    {
        public string Status() => "Off";
    }
    public class OffStatus : TvPowerAction
    {
        public string Status() => "On";
    }
    public class TV
    {
        private TvPowerAction TvPowerAction;
        public bool IsOn { get; set; }
        public string Status { get; set; }

        public void PowerPush()
        {
            Status = TvPowerAction.Status();
        }
    }
}
