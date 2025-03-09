using ConsoleApp2.Migrations;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext _context = new CompanyContext();

            var Depts = _context.Departments.ExecuteDelete();

            _context.SaveChanges();
            













            //CompanyContext _context = new CompanyContext();

            //var Depts = _context.Departments
            //        .Include(dp => dp.DeptProjects)
            //            .ThenInclude(d => d.project).ToList();

            //var Depts1 = _context.Departments.AsSplitQuery()
            //         .Include(dp => dp.DeptProjects)
            //            .ThenInclude(d => d.project).ToList();
            //both are equivalent

            //var Depts = _context.Departments.ToList();

            //foreach (var dept in Depts)
            //{
            //    _context.Entry(dept).Collection(a => a.employees).Load();
            //}




            //var DeptEmployees = _context.Entry(dept).Collection(a => a.employees).Query().ToList();//Eager execution
            //foreach (var employee in DeptEmployees) 
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //Lazy Loading
            //Console.WriteLine("Lazy Loading");
            //var Depts1 = _context.Departments.ToList();
            //foreach(var dept in Depts1)
            //{
            //    Console.WriteLine(dept.DeptName);
            //    foreach(var emp in dept.employees)
            //    {
            //        Console.WriteLine($"--{emp.Name}");
            //        Console.WriteLine(emp.Salary);
            //    }
            //}
            ////will do join (Departments with Employees) without filteration over database

            //Console.WriteLine("Explicit Loading");
            ////Explicit Loading
            //var Depts2 = _context.Departments.ToList();
            //foreach (var dept in Depts2)
            //{
            //    var emps = _context.Entry(dept).Collection(a => a.employees).Query().Where(e => e.Salary > 5000).ToList();
            //    //will do join and filteration over database
            //    Console.WriteLine(dept.DeptName);
            //    foreach (var emp in emps)
            //    {
            //        Console.WriteLine($"--{emp.Name}");
            //        Console.WriteLine(emp.Salary);
            //    }
            //}

            //CompanyContext _context = new CompanyContext();

            //var emps = _context.Employees.IgnoreQueryFilters().ToList();




            //CompanyContext _context = new CompanyContext();
            //var Id = int.Parse(Console.ReadLine());
            //var employees = _context.Employees.FromSql($"EXEC [dbo].[GetEmployeesByDepartmentId] {Id}").AsEnumerable().ToList() ;
            //foreach(var employee in employees)
            //{
            //    Console.WriteLine(employee.Name);
            //}


            //_context.EmployeeAddress.Where(a => a.Address == "Giza").ExecuteUpdate(a => a.SetProperty(a => a.Address, a => a.Address + "NewGiza"));
            //_context.EmployeeAddress.ExecuteUpdate(a => a.SetProperty(a => a.Address, a => a.Address + "NewGiza"));



            //_context.Employees.ExecuteDelete();//delete all rows of Employee table
            //_context.Employees.Where(e => e.EmployeeId == 1).ExecuteDelete();

            //var ListAddress = _context.EmployeeAddress.ToList();
            //foreach(var addresss in ListAddress)
            //{
            //    _context.Remove(addresss);
            //}
            //_context.SaveChanges();
        }
    }
}
