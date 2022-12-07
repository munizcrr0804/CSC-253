/**
* 9/29/2022
* CSC 253
* Ramon Muniz Crespo
* List Manipulator
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace List_Manipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Function that checks for negative numbers
        private static bool isNegative(int i)
        {
            return (i < 0);
        }

        //Function that checks for numbers between 1 to 10
        private static bool inRange(int i)
        {
            return (i >= 1 && i <= 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Declaring list
            List<int> elements = new List<int>();
            // Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader("random.txt"))
            {
                string ln;

                //Reading line by line
                while ((ln = file.ReadLine()) != null)
                {
                    //Adding to list
                    elements.Add(Convert.ToInt32(ln));
                }

                //Closing file
                file.Close();
            }

            //Writing elements to list box
            lstActual.DataSource = elements;

            //Removing Negative elements
            elements.RemoveAll(isNegative);

            //Writing elements to list box
            lstPositive.DataSource = elements;

            //Finding all numbers in range 1 to 10
            List<int> elements_1_10 = elements.FindAll(inRange);

            //Writing elements to list box
            lst_1_10.DataSource = elements_1_10;
        }
    }
}
