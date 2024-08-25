using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee { ID = 1, FirstName = "John", LastName = "Johnson" });
            emp.Add(new Employee { ID = 2, FirstName = "Joe", LastName = "Williams" });
            emp.Add(new Employee { ID = 3, FirstName = "Joe", LastName = "James" });
            emp.Add(new Employee { ID = 4, FirstName = "Emma", LastName = "Brown" });
            emp.Add(new Employee { ID = 5, FirstName = "Michael", LastName = "Jones" });
            emp.Add(new Employee { ID = 6, FirstName = "Sophia", LastName = "Rodriguez" });
            emp.Add(new Employee { ID = 7, FirstName = "James", LastName = "Lopez" });
            emp.Add(new Employee { ID = 8, FirstName = "Olivia", LastName = "Martinez" });
            emp.Add(new Employee { ID = 9, FirstName = "Jamie", LastName = "Anderson" });
            emp.Add(new Employee { ID = 10, FirstName = "Isabella", LastName = "Thomas" });
            emp.Add(new Employee { ID = 11, FirstName = "Joe", LastName = "Moore" });
            emp.Add(new Employee { ID = 12, FirstName = "Matthew", LastName = "Jackson" });

            List<Employee> joes = new List<Employee>();

            foreach (Employee employee in emp)
            {
                Console.WriteLine($"ID: {employee.ID}, First Name: {employee.FirstName}, Last Name: {employee.LastName} ");
                if(employee.FirstName == "Joe")
                {
                    joes.Add(new Employee { ID = employee.ID, FirstName = employee.FirstName, LastName = employee.LastName }); 
                }
            }
            Console.WriteLine("\nFirst name of Joe:");
            foreach (Employee employee in joes)
            {
                Console.WriteLine($"ID: {employee.ID}, First Name: {employee.FirstName}, Last Name: {employee.LastName} ");
            }


            List<Employee> lambdaJoes = new List<Employee>();
            lambdaJoes = emp.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Joes in the lambda:");
            foreach(Employee joe in lambdaJoes)
            {
                Console.WriteLine($"ID: {joe.ID}, First Name: {joe.FirstName}, Last Name: {joe.LastName} ");
            }
            
            Console.ReadLine();

        }
    }
}
