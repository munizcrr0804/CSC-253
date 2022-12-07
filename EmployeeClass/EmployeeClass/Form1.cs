/**
* 11/17/2022
* CSC 253
* Ramon Muniz
* WinForm
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

namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        /* create three instances of Employee class and set
   name,id, department and position for each object
   of employee class.*/
        private Employee empObj1 = new Employee("Susan Meyers",
        47899, "Accounting", "Vice President");
        private Employee empObj2 = new Employee("Mark Jones",
         39119, "IT", "Programmer");
        private Employee empObj3 = new Employee("Joy Rogers",
         81774, "Manufacturing", "Engineer");


        public Form1()
        {
            InitializeComponent();
        }
          private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            /*First text box values gets the employee 1 object
      Properties*/
            txtEmp1.Text = empObj1.Name + "," +
            empObj1.IdNumber + "," + empObj1.Department + "," + empObj1.Position;
            /* Second text box values gets the employee 2 object
               Properties*/
            txtEmp2.Text = empObj2.Name + "," +
             empObj2.IdNumber + "," +
             empObj2.Department + "," +
             empObj2.Position;
            /* Third text box values gets the employee 3 object
               Properties */
            txtEmp3.Text = empObj3.Name + "," +
               empObj3.IdNumber + "," +
               empObj3.Department + "," +
               empObj3.Position;
        }

        }
}