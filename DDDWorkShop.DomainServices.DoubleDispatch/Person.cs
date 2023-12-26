using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.DomainServices.DoubleDispatch
{
    public interface IGetWether
    {
        int Get(Person person);
    }
    public class GetTehranWeather : IGetWether
    {
        public int Get(Person person)
        {
            return 11;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GtWeather(IGetWether getWether)
        {
            return getWether.Get(this);
        }
    }
}
