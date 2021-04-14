using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Shared
{
    public class Cart
    {
        public List<int> Orders { get; set; } = new List<int>();

        public void Add(int productId) {
            Orders.Add(productId);
        }

        public void Remove(int postion) {
            Orders.RemoveAt(postion);
        
        }
    }
}
