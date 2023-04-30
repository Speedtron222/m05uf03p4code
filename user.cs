using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5uf03p4code
{
    internal class user
    {
        private string name;        
        private string surname;
        private string password;
        private string NIF;
        private string email;
        private string address;
        private string phoneNumber;
        public List<product> wishlist = new List<product>();

        public user(string name, string surname, string password, string NIF, string email, string address, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.NIF = NIF;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public void delUser()
        {
            return;//Deletes user account from database.
        }

        public void addProdToWL(product p) 
        {
            wishlist.Add(p); //Adds a product p to the WL.
        }
        public void removeProdFromWL(product p) 
        {
            wishlist.Remove(p); //Removes a product p from the WL.
        }
        public void changePassword(string oldPass, string newPass)
        {
            if(password == oldPass)
            {
                password = newPass; //Changes the password to a new one but only if the fist input is the old one.
            }
        }
    }
}
