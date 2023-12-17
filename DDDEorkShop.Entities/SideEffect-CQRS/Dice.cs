using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.SideEffect_CQRS
{
    public class Dice
    {
        private int value;
        public void Roll() {
            Random random = new Random();
            value = random.Next(0, 7);
        }
        public int Value()
        {
            
            return value;
        }
    }
}
