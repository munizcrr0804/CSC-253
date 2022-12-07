using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Search
{
    internal class Product
    {
        public string ProductNumber;

        public string Description;

        public int UnitsOnHand;

        public double Price;

        // constructor

        public Product(string productNumber, string description, int unitsOnHand, double price)

        {

            ProductNumber = productNumber;

            Description = description;

            UnitsOnHand = unitsOnHand;

            Price = price;

        }

        // Tostring override

        public override string ToString()

        {

            return ProductNumber + ", " + Description + ", " + UnitsOnHand + ", " + Price.ToString("c");

        }

    }

}
    

    


