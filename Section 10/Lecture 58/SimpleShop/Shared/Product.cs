using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Shared
{
    public enum Catagory { 
    Sport,
    Cloth,
    Furniture
    }
   public class Product
    {
        public Product(int id,string name, decimal price, Catagory catagory )
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Catagory = catagory;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Catagory Catagory { get; set; }
    }
}
