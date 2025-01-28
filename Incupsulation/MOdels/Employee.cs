using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incupsulation.MOdels
{
    internal class Employee
    {
        public string Name { get; set; }
        public bool IsProbationPassed { get; set; }
        private int salary;
        public void SalaryGiving(int sum)
        {
            if (IsProbationPassed == true)
            {
                salary = sum;
                Console.WriteLine($"passed Salary equal to {salary}");
            }
            else
            {
                Console.WriteLine("Not passed");
            }
        }
    }
}
