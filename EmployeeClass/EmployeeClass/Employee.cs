/**
* 3/1/2021
* CSC 153
* Ramon Muniz
* EmployeeClass
*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    public class Employee
    {
        //fields of the Employee class
        private string _name;
        private decimal _idNumber;
        private string _department;
        private string _position;

        /* Parameter less constructor that sets the default            values
          of the fields */
        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";

        }
        /* constructor that sets the name, id number department            and
           Position */
        public Employee(string name, decimal idNumber,
        string department, string position)
        {
            _name = name;
            _idNumber = idNumber;
            _department = department;
            _position = position;

        }


        /* constructor that sets the name and id number and empty
           string to the department and position */
        public Employee(string name, decimal idNumber)
        {
            _name = name;
            _idNumber = idNumber;
            _department = "";
            _position = "";

        }
        //Name property that holds the name
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        //IdNumber property that holds the id number
        public decimal IdNumber
        {
            set { _idNumber = value; }
            get { return _idNumber; }
        }

        //Department property that holds the department name.
        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }
        //Position property that holds the position of a employee
        public string Position
        {
            set { _position = value; }
            get { return _position; }
        }

    }//end of the Employee class

}
