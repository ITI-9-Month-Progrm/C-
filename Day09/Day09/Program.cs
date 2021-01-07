using System;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(123, new DateTime(1980, 5, 12), 15);
            Employee emp2 = new Employee(456, new DateTime(1990, 5, 12), 10);
            Employee emp3 = new Employee(789, new DateTime(1980, 5, 12), 5);
            Employee emp4 = new Employee(333, new DateTime(1950, 5, 12), 20);
            BoardMember b = new BoardMember(111, new DateTime(1950, 12, 20));
            SalesPerson b2 = new SalesPerson(12, new DateTime(1950, 12, 20), 10);

            Department dep = new Department(1, "dep1");
            Club c = new Club(2, "club1");
            c.AddMember(emp1);
            c.AddMember(emp2);
            c.AddMember(emp3);
            c.AddMember(emp4);
            c.AddMember(b);
            c.AddMember(b2);


            dep.AddStaff(emp1);
            dep.AddStaff(emp2);
            dep.AddStaff(emp3);
            dep.AddStaff(emp4);
            dep.AddStaff(b);
            dep.AddStaff(b2);



            emp1.RequestVacation(new DateTime(2020, 5, 1), new DateTime(2020, 5, 20));
            emp2.RequestVacation(new DateTime(2020, 5, 1), new DateTime(2020, 5, 4));
            emp3.EndOfYearOperation();
            emp4.EndOfYearOperation();


            b.RequestVacation(new DateTime(2020, 5, 1), new DateTime(2020, 5, 20));
            b.EndOfYearOperation();
            b.Resign();
            b2.CheckTarget(20);

            Console.WriteLine("Done");
        }
    }
}
