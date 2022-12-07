/**
* 8/25/2022
* CSC 253
* Ramon Muniz Crespo
* Area class
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

namespace Area_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double area(double radius)
        {
            return (Math.PI * radius * radius);
        }

        private static double area(int width, int length)
        {
            return (width * length);
        }

        private static double area(double radius, double height)
        {
            return (Math.PI * radius * radius * height);
        }


        private void btn_AreaCircle_Click(object sender, EventArgs e)
        {
            double radius;

            radius = Convert.ToInt32(txtRadiusCircle.Text);

            txtAreaCircle.Text = Math.Round(area(radius), 2).ToString();

        }

        private void btn_AreaRectangle_Click(object sender, EventArgs e)
        {
            int length, width;

            length = Convert.ToInt32(txtWidth.Text);

            width = Convert.ToInt32(txtLength.Text);

            txtAreaRectangle.Text = Math.Round(area(length, width), 2).ToString();


        }

        private void btn_AreaCylinder_Click(object sender, EventArgs e)
        {
            double radius, height;

            radius = Convert.ToDouble(txtRadiusCylinder.Text);

            height = Convert.ToDouble(txtHeight.Text);

            txtAreaCylinder.Text = Math.Round(area(radius, height), 2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAreaCircle.Enabled = false;
            txtAreaRectangle.Enabled = false;
            txtAreaCylinder.Enabled = false;
        }
    }
}
