/**
* 10/3/2022
* CSC 253
* Ramon Muniz
* House Price Analysis
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Price_Analysis
{
    public partial class Form1 : Form
    {
        // Class level variable to store the housing details

        List<HousePrice> housePrices;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // IInitializes the list

            housePrices = new List<HousePrice>();

            // Read the CSV file

            var lines = File.ReadLines("input.csv");

            foreach (string line in lines)

            {

                string[] tokens = line.Split(',');

                // Create new object and add it to list

                housePrices.Add(new HousePrice(double.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3])));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Clear Any previous results

            lbResults.Items.Clear();

            // get search criteria

            // Assuming user will be inputtin valid values

            int bedroom1 = int.Parse(txtBedRoom1.Text);

            int bedroom2 = int.Parse(txtBedRoom2.Text);

            int bathroom1 = int.Parse(txtBathRoom1.Text);

            int bathroom2 = int.Parse(txtBathRoom2.Text);

            int squarefeet1 = int.Parse(txtSquareFeet1.Text);

            int squarefeet2 = int.Parse(txtSquareFeet2.Text);

            // Use LINQ - FindAll method

            var searchResults = housePrices.FindAll(x => x.Bedrooms >= bedroom1 && x.Bedrooms <= bedroom2

            && x.Bathrooms >= bathroom1 && x.Bathrooms <= bathroom1

            && x.SquareFeet >= squarefeet1 && x.SquareFeet <= squarefeet2);

            // Display the result in a listbox

            foreach (HousePrice house in searchResults)

            {

                lbResults.Items.Add(house.ToString());
            }
        }
    }

}