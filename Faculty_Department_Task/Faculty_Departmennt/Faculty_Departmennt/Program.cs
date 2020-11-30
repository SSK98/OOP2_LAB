using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty_Departmennt
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty("Apha", "001");
            Faculty f2 = new Faculty("Bravo", "002");
            Faculty f3 = new Faculty("Charlie", "003");
            Faculty f4 = new Faculty("Delta", "004");
            Department d = new Department("CSE", "1");
            d.AddFaculty(f1, f2, f3, f4);
            d.ShowAllFaculty();
            Console.WriteLine("#########################################");
            var faculty = d.SearchFaculty("002");
            if(faculty != null)
            {
                d.DeleteFaculty(faculty);
            }
            d.ShowAllFaculty();
        }
    }
}
