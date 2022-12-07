using System;
/**
* 8/17/2022
* CSC 153
* Ramon Muniz
* KineticEnergy
*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KineticEnergy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcKE_Click(object sender, EventArgs e)
        {
            // Get the object's Mass from the
            // massTextBox
            double m = double.Parse(massTextBox.Text);

            // Get the Object's Velocity from the
            // velocityTextBox
            double v = double.Parse(velocityTextBox.Text);

            // Call the kineticEnergy  to get 
            // The Kinetic Energy 
            double ke = KineticEnergy(m, v);

            // display the Kinetic Energy in
            // The lblKineticEnergy
            lblKineticEnergy.Text = ke.ToString("E2");
        } // end of btnCalc_Click event
          // btnExit_Click event implementation

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        } // end of btnExit_Click event

        private double KineticEnergy(double m, double v)
        {
            return (0.5 * m * v * v);

        } // end of KineticEnergy

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } // end of class 

    } // end of namespace

