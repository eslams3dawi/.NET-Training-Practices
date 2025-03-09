
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        class Employee
        {
            readonly int x;
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
        }

        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmployeeID = 1, Name = "Ali", Department = "IT", Salary = 6000 },
                new Employee { EmployeeID = 2, Name = "Sara", Department = "HR", Salary = 4500 },
                new Employee { EmployeeID = 3, Name = "Omar", Department = "Finance", Salary = 7000 },
                new Employee { EmployeeID = 4, Name = "Mona", Department = "IT", Salary = 8000 },
                new Employee { EmployeeID = 5, Name = "Tamer", Department = "Marketing", Salary = 3000 },
                new Employee { EmployeeID = 6, Name = "Aya", Department = "HR", Salary = 5000 }
            };

            var emp = new Employee() { Name = "Moaz" };
            emp.Name = "Eslam";

            //1
            var EmployeesNames = employees.Where(e => e.Salary >= 5000).Select(e => e.Name).ToList();
            foreach (var name in EmployeesNames)
            {
                Console.WriteLine(name);
            }

            //3
            var Employees = employees.Where(e => e.Salary > 4000).Take(2);
            foreach (var emp in Employees)
            {
                Console.WriteLine(emp.Name);
            }

            //4
            var Employees = employees.TakeLast(3);
            foreach (var Emp in Employees)
            {
                Console.WriteLine(Emp.Name);
            }

            //2
            //1
            var CountOfEmployees = employees.Count();
            Console.WriteLine(CountOfEmployees);

            //2
            var SumOfSalary = employees.Where(e => e.Salary > 3000).Sum(e => e.Salary);
            Console.WriteLine(SumOfSalary);


            var AvgSalary = employees.Where(e => e.Salary > 3000).Average(e => e.Salary);
            Console.WriteLine(AvgSalary);

            //3
            var Max = employees.Max(e => e.Salary);
            Console.WriteLine(Max);

            var Min = employees.Min(e => e.Salary);
            Console.WriteLine(Min);


            var Emp = employees.First();
            Console.WriteLine(Emp.Name);

            var ThirdEmp = employees[2];
            Console.WriteLine(ThirdEmp.Name);

            try
            {
                var Emp = employees[1];
                throw new ArgumentOutOfRangeException("Out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            var Empw = employees.FirstOrDefault();

            var Ordered = employees.OrderBy(e => e.Salary);
            foreach (var emp in Ordered)
            {
                Console.WriteLine(emp.Name);
            }

            var Ordering = employees.OrderByDescending(e => e.Salary).ThenBy(e => e.Salary);
            foreach (var emp in Ordering)
            {
                Console.WriteLine(emp.Name);
            }

            var ArrayEmployee = employees.ToArray();
            foreach (var Emp in ArrayEmployee)
            {
                Console.WriteLine(Emp.Name);
            }

            var DicEmployee = employees.ToDictionary(e => e.EmployeeID, e => e.Name);
            foreach (var Emp in DicEmployee)
            {
                Console.WriteLine(Emp.Value);
            }

            var IsGreaterThan2000 = employees.All(e => e.Salary > 2000);
            Console.WriteLine(IsGreaterThan2000);

            var IsAnyGreaterThan10000 = employees.Any(e => e.Salary > 10000);
            Console.WriteLine(IsAnyGreaterThan10000);

            var EmpNames = employees.Where(e => e.Name.Contains("Ali"));
            var EmpM = employees.Where(e => e.Name.StartsWith("M"));

            foreach (var emp in EmpNames)
            {
                Console.WriteLine(emp.Name);
            }
            Console.WriteLine("===========");
            foreach (var emp in EmpM)
            {
                Console.WriteLine(emp.Name);
            }

            List<string> dept1 = new List<string>() { "HR", "IT", "Finance", "Marketing", "Sales" };
            List<string> dept2 = new List<string>() { "Admin", "IT", "Operations", "Finance", "Support" };
            var depts = dept1.Union(dept2).ToList();
            foreach (var dept in depts)
            {
                Console.WriteLine(dept);
            }

            var depts2 = dept1.Intersect(dept2).ToList();
            foreach (var dept in depts2)
            {
                Console.WriteLine(dept);
            }

            var AllDepts = dept1.Concat(dept2).ToList();
            foreach (var dept in AllDepts)
            {
                Console.WriteLine(dept);
            }

            var ExceptInDept2 = dept2.Except(dept1).ToList();
            foreach (var dept in ExceptInDept2)
            {
                Console.WriteLine(dept);
            }

            var Depts = employees.GroupBy(e => e.Department).ToList();
            foreach (var Dept in Depts)
            {
                Console.WriteLine($"Department: {Dept.Key}");
                foreach (var Employee in Dept)
                {
                    Console.WriteLine(Employee.Name);
                }
            }

            Stopwatch sw = new Stopwatch();
                int Size = 3;
                int NumberOfPages = (int)Math.Ceiling((double)employees.Count / 3);
                sw.Start();
                for (int Page = 0; Page < NumberOfPages; Page++)
                {
                    var Emps = employees.Skip(Page * Size).Take(Size);
                    foreach (var Employee in Emps)
                    {
                        Console.WriteLine(Employee.Name);
                    }
                }
                sw.Stop();
                Console.WriteLine($"time in pagination: {sw}");

                sw.Reset();
                sw.Start();
                foreach (var emp in employees)
                {
                    Console.WriteLine(emp.Name);
                }
                sw.Stop();
                Console.WriteLine($"time in normal way: {sw}");
                a a = new a();
            }

        }
    }
}
