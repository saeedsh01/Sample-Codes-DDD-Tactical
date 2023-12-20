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
        public string Status()
        {
            return "Off";
        }
<<<<<<< HEAD
=======

>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f
    }
    public class OffStatus : TvPowerAction
    {
        public string Status()
        {
            return "On";
        }
<<<<<<< HEAD
=======

>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f
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
