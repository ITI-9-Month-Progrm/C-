using System;

namespace Task1
{
    class Program
    {
        public static bool isInt(string number)
        {
           
            int no = 0;
            if (int.TryParse(number, out no))
            {
                return true;
                //Response.Write(no.ToString() + " is a valid number!");
            }
            else
            {
                return false;
               //Response.Write(no.ToString() + " is not a valid number!");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //why not d,m,y///////////
            int id=0, d=0, m=0, y=0, len;
            double sal=0.0;
            Gender  gen=new Gender();
            Date Hdate=new Date();
            Security_Level Slevel=new Security_Level();
            string g, sl, s,date,dateAgain;
            string[] splitDate;
            bool res = false;
            Employee[] emp = new Employee[1];
            len = emp.Length;



            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("\t\tPlease Enter Informaton of Employee " + (i + 1));
                Console.WriteLine("Please Enter Emp_ID");
                while (res == false)
                {
                    s = Console.ReadLine();
                    res = isInt(s);
                    if (res) { id = int.Parse(s); }
                    else { Console.WriteLine("Please enter Correct number"); }
                }

                Console.WriteLine("Please Enter Emp_Security_Level");
                sl = Console.ReadLine();
                Slevel = (Security_Level)Enum.Parse(typeof(Security_Level), sl);

                Console.WriteLine("Please Enter Emp_Salary");
                res = false;
                while (res == false)
                {
                    sal = double.Parse(Console.ReadLine());
                    if (sal>=1200 || sal>=5000) { res = true; }
                    else { Console.WriteLine("Please Enetr Correct Salary"); }
                }
                
                do
                {
                    Console.WriteLine("Please Enetr Emp_HDate Like as 00/00/0000");
                    
                  date = Console.ReadLine();
                  splitDate = date.Split("/");
                   
                    d = int.Parse(splitDate[0]);
                    m = int.Parse(splitDate[1]);
                    y = int.Parse(splitDate[2]);

                } while ((d<1 || d>31) || (m<1 || m>12) ||((y%4!=0)||(m!=2)||(d!=29)));

                Console.WriteLine("Please Enter Emp Gender If male Enter M other F");
                
                res = false;
                while (res == false)
                {
                    g = Console.ReadLine();
                    if(g=="M" ||  g=="F" ) 
                    { res = true; gen = (Gender)Enum.Parse(typeof(Gender), g); }
                    else {
                        res = false;
                        Console.WriteLine("Please Enter Correct Emp Gender If male Enter M  other F "); 
                    }
                }

                emp[i].setID(id);
                emp[i].setSecurityLevel(Slevel);
                emp[i].setSalary(sal);
                Hdate.Day = d;
                Hdate.Month=m;
                Hdate.Year=y;
                emp[i].setHD(Hdate);
                emp[i].setGender(gen);
               
              }
            Console.Clear();
            string result;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("\t\tThis is Information for Employee" + (i + 1));
                result = emp[i].ToString();
                Console.WriteLine(result);
                Console.WriteLine();

            }
        }
    }
}
