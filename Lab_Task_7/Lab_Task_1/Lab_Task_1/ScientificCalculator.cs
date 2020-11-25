using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_7
{
    class ScientificCalculator : IBasicCalculator
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public ScientificCalculator(string name, string model)
        {
            Name = name;
            Model = model;
        }
        ///implementing Basic Calculator Interface
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
        ///implementing Scientific Calculator Interface
        public int XtoY(int x, int y)
        {
            int res = 0;
            for(int i=0;i<y;i++)
            {
                res += x;
            }
            return res;
        }
        public double Square(int x)
        {
            return x * x;
        }
        public double Sine(int x)
        {
            return Math.Sin(x);
        }
    }
}
