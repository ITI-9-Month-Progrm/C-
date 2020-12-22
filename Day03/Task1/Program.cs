using System;

namespace Task1
{
    class Program
    {
         static void Main(string[] args)
         {
            Console.WriteLine("Hello World!");
            int id, sl, d, m, y, len;
            double salary;
            Date Hdate = new Date();
            Gender gen;
            string res, date, g;
            string[] splitDate;
            Employee[] emp = new Employee[3];
            len = emp.Length;

            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("\t\tPlease Enter Informaton of Employee " + (i + 1));
                Console.WriteLine("Please Enter Emp_ID");
                id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Please Enter Emp_Security_Level");
                sl = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Please Enter Emp_Salary");
                salary = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Please Enetr Emp_HDate Like as 00/00/0000");
                date = Console.ReadLine();
                splitDate = date.Split("/");
                
                d = int.Parse(splitDate[0]);
                
                
                m = int.Parse(splitDate[1]);
               
                
                y = int.Parse(splitDate[2]);
                
                Console.WriteLine("Please Enter Emp Gender If male Enter M other F");
                g=Console.ReadLine();
                gen =(Gender)Enum.Parse(typeof(Gender),g);
                ///////put data
                emp[i].setID(id);
                emp[i].setSecurityLevel(sl);
                emp[i].setSalary(salary);
                Hdate.setDay(d);
                Hdate.setMonth(m);
                Hdate.setYear(y);
                emp[i].setHD(Hdate);
                emp[i].setGender(gen);
                

            }
            Console.Clear();
            for (int i = 0; i < len; i++) { 
                Console.WriteLine("\t\tThis is Information for Employee" + (i + 1));
                res = emp[i].ToString();
                Console.WriteLine(res);
                Console.WriteLine();

            }
        }
    }
}
