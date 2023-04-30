using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5uf03p4code
{
    internal class review
    {
        public product p;
        public string userName;
        public string comment;
        public float userRating;
        
        public void updateProductRating()
        {
            p.rating = (p.rating + userRating) / 2; // Makes an average with the current average rating of the reviewed product.
        }
    }
}
