using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            
            Console.WriteLine("Please enter your Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter your Age");
            employee.Age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Address");
            employee.Address = Console.ReadLine();
            Console.WriteLine("Please enter your Phone");
            employee.Phone = Console.ReadLine();
            Console.WriteLine("In which department do you work?");
            employee.Department = Console.ReadLine();
            Console.WriteLine("Your rights:");
            employee.salary();
            Console.ReadKey();
        }
    }
     abstract public class Boss
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    public class Manager :Boss
    {
        public string Department { get; set; }

        public virtual void salary()
        {
            Console.WriteLine("Salary: 50000");
        }
    }
    
    sealed public class Employee : Manager
    {
        public override void salary()
        {
            Console.WriteLine("Salary: 10000");
        }
    }
}
