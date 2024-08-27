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
            // Creating a list of type Employee and adding in different people
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

            // In this foreach loop we are parsing through the emp list and if the firstname is Joe,
            // we are adding it to the new joes list.
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"ID: {employee.ID}, First Name: {employee.FirstName}, Last Name: {employee.LastName} ");
                if(employee.FirstName == "Joe")
                {
                    joes.Add(new Employee { ID = employee.ID, FirstName = employee.FirstName, LastName = employee.LastName }); 
                }
            }
            // Printing the list of employees with the name Joe
            Console.WriteLine("\nFirst name of Joe:");
            foreach (Employee employee in joes)
            {
                Console.WriteLine($"ID: {employee.ID}, First Name: {employee.FirstName}, Last Name: {employee.LastName} ");
            }

            // creating a new list where we will parse and add all the Joes to the
            // lambdaJoes list with a lambda
            List<Employee> lambdaJoes = new List<Employee>();
            // After the List is crated, we can use the .Where() method to parse the emp list, then use
            // the .ToList() method to add them to the list at the end of the lambda.
            lambdaJoes = emp.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("Joes in the lambda:");
            foreach(Employee joe in lambdaJoes)
            {
                Console.WriteLine($"ID: {joe.ID}, First Name: {joe.FirstName}, Last Name: {joe.LastName} ");
            }

            // #5 where we use a lambda to see all employees whos id is greater than 5
            List<Employee> empGrtrThan5 = new List<Employee>();

            empGrtrThan5 = emp.Where(x => x.ID > 5).ToList();
            Console.WriteLine("List of employees where ID is greater than 5:");
            foreach(Employee emp1 in empGrtrThan5)
            {
                Console.WriteLine($"ID: {emp1.ID}, First Name: {emp1.FirstName}, Last Name: {emp1.LastName}");
            }
            
            Console.ReadLine();

        }
    }
}
