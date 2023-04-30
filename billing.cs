using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5uf03p4code
{
    internal class billing
    {
        public int id;
        public user customer;
        public List<product> productsBuying = new List<product>();
        public float totalPrice;

        public float calcPrice(List<product> productsBuying)
        {
            // Traverses the list of products adding each price and returns the result.
            return 0;
        }

        public void insertPrice()
        {
            totalPrice = calcPrice(productsBuying); 
            //Fills totalPrice variable with the addition of the prices from all the products in the list.
        }
    }
}