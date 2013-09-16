using samplesDF;
using samplesDF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employee = new EmployeeService();
            int result;
           List<EmployeeInfo> list= employee.GetEmployees("","", "","lastname","asc", 1, 2,out result);
           Console.WriteLine("Name:   LastName:     Organization Level:     Gender:\n");
           foreach (EmployeeInfo item in list)
           {               
               Console.WriteLine(item.name + "     " + item.lastname + "               " + item.orglevel + "                  " + item.gender);
           }
            
           Console.ReadLine();
        }
    }
}
