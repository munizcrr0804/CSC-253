/**
* 10/3/2022
* CSC 253
* Ramon Muniz
* House Price Analysis
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price_Analysis
{
    class HousePrice
    {
        // Properties

        public double Price { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public int SquareFeet { get; set; }

        /// <summary>

        /// Constructord

        /// </summary>

        /// <param name="price"></param>

        /// <param name="bedrooms"></param>

        /// <param name="bathromms"></param>

        /// <param name="squareFeet"></param>

        public HousePrice(double price, int bedrooms, int bathrooms, int squareFeet)

        {

            Price = price;

            Bedrooms = bedrooms;

            Bathrooms = bathrooms;

            SquareFeet = squareFeet;

        }

        public override string ToString()

        {

            return this.Price.ToString("C") + ", " + this.Bedrooms + ", " + this.Bathrooms + ", " + this.SquareFeet;
        }
    }
}