using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_to_Fahrenheit_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click_Click(object sender, EventArgs e)
        {
            double cel = 0.0;

            double fah = 0.0;

            lCelsiusToFahrenheit.items.Clear();

            while (cel <= 20)

            {

                fah = (9 * cel / 5) + 32;

                lstCelsiusToFahrenheit.items.Add(cel.ToString() + "Celsius is equal to " + fah.ToString() + " fahrenheit");

                cel++;

            }

        }

    }
}
