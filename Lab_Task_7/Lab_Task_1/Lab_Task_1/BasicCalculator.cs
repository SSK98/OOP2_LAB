using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_7
{
    class BasicCalculator : IBasicCalculator
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public BasicCalculator(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public double division(int x, int y)
        {
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }
    }
}
