using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.Memento
{
    public class Product
    {
        public int id { get; set; }
    }
    public class Basket
    {
        private int id;
        private DateTime creatDate;
        private List<Product> products;
        public void Add(Product prduct)
        {

        }
        public void Remove(Product prduct)
        {

        }
        public int GetTotalPrice()
        {
            return 0;
        }
    }

  
}
