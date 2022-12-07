using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car_Class
    {

        private string Make;
        private int Year;
        private int GetSpeed;

        public Car_Class()
        {
            Make = "";
            Year = 0;
            GetSpeed = 0;
        }

        public void Accelerate()
        {
            this.GetSpeed += 5;
        }

        public void Brake()
        {
            this.GetSpeed -= 5;
        }

        public int getSpeed()
        {
            return GetSpeed;
        }



        }
    }
