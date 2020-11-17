using System;
using System.Collections.Generic;

public class Company
{
    public string Name { get; }
    public DateTime CreatedOn { get; }

    public List<Employee> Employees = new List<Employee>();

    public Company(string name, DateTime created)
    {
        Name = name;
        CreatedOn = created;
    }
}

public class Employee
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Title { get; }
    public DateTime StartDate { get; }

    public Employee(string first, string last, string title, DateTime start)
    {
        FirstName = first;
        LastName = last;
        Title = title;
        StartDate = start;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Company store = new Company("Stuff Store", DateTime.Now);

        Employee hack = new Employee("Jay", "Bauman", "VCR Repairman", DateTime.Now);
        Employee fraud = new Employee("Mike", "Stoklasa", "VCR Repairman", DateTime.Now);
        Employee dead = new Employee("Rich", "Evans", "Probably dead", DateTime.Now);

        store.Employees.Add(hack);
        store.Employees.Add(fraud);
        store.Employees.Add(dead);

        foreach(Employee employee in store.Employees)
        {
            Console.WriteLine($@"
            {employee.FirstName} {employee.LastName}
            Title: {employee.Title}
            Date Started: {employee.StartDate}
            ");
        }
    }
}