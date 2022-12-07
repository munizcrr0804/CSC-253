/**
* 8/24/2022
* CSC 253
* Ramon Muniz Crespo
* Car_Class
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

namespace Car_Class
{
    public partial class Car_Class : Form
    {
        private Car_Class car;
        
      
        public Car_Class()
        {
            InitializeComponent();
        }

        private void btnAccelerate_Click_Click(object sender, EventArgs e)
        {
            if (makeTxtBox.Text == String.Empty || yearTxtBox.Text == String.Empty)

                MessageBox.Show("Make and Year are empty");
                
                else
            
            {
                car.Accelerate();

                speedLabel.Text = Convert.ToString(car.GetSpeed());



            }

        }

        private void btnBrake_Click_Click(object sender, EventArgs e)
        {


            if (makeTxtBox.Text == String.Empty || yearTxtBox.Text == String.Empty)

                MessageBox.Show("Make and Year are empty");

            else
            {

                if (car.GetSpeed() > 0)
                    car.Brake();

                else
                {
                    MessageBox.Show("Speed cannot be negative", "Error");

                    speedLabel.Text = Convert.ToString(car.GetSpeed());
                } 






            }





        }
    }
    }
