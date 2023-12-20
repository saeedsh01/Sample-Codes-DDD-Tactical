using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.Memento
{
<<<<<<< HEAD
    /// <summary>
    /// Sample Memento Pattern
    /// </summary>
    public class BasketSnapshot
    {
        public int ProductCount { get; set; }
        public int Id { get; set; }
    }
=======
>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f
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
<<<<<<< HEAD
        public decimal GetTotalPrice()
        {
            return 0.0m;
        }
        public BasketSnapshot GetSnapshot()
        {
            return new BasketSnapshot { 
                Id = this.id,
                ProductCount=10
            };
        }
    }


=======
        public int GetTotalPrice()
        {
            return 0;
        }
    }

  
>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f
}
