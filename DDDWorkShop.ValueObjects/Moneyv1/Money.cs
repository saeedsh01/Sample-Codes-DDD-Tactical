using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDWorkShop.ValueObjects.Moneyv1
{
    public class Money
    {
        protected readonly decimal Value;

        public Money( decimal value)
        {
            Value = value;
        }
        public Money() : this(0m)
        {

        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

     

        public static bool operator ==(Money a, Money b)
        {           
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            //var aa = ReferenceEquals(a,b);
            //var bb = ReferenceEquals(a,a);
            //var cc = ReferenceEquals(b,b);
            //var dd = a == b;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
             
            return a.Equals(b);
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            var valueObject = obj as Money;
            if (ReferenceEquals(valueObject, null))
                return false;
            return this.Value == valueObject.Value;
        }

    }
}
