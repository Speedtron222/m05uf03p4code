using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace m5uf03p4code
{
    internal class product
    {
        public int id;
        public float price;
        public string name;
        public string brand;
        public string description;
        public string highCat;
        public string? medCat; //Accepts a null value.
        public string lowCat;
        public string pic;
        public bool discount = false;
        public bool visible = false;
        public float rating;

        public void delProduct() 
        {
            return; //Searches for the product and deletes it.
        }
        public void addDiscount(int disValue)
        {
            discount = true;
            price = price * disValue / 100; 
            //Changes the price multiplying by a discount value, ex: newPrice = previousPrice(200) * disValue(70) / 100 = 140 (30% discount).
        }
        public void hideOrShowProduct()
        {
            visible = !visible; //Makes invisble visible products and vice versa.
        }
        public void setPic(string picURL)
        {
            pic = picURL; //Sets an URL for pic variable.
        }
    }
}