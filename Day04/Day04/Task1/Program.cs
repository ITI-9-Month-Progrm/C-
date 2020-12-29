using System;

namespace Task1
{
    class Program
    {
        public static bool isInt(string number)
        {
           
            int no = 0;
            if (int.TryParse(number, out no) && no>0)
            {
                return true;
                
            }
            else
            {
                return false;
               
            }
        }
        public static bool isString(string s)
        {
            int len;len = s.Length;
            bool flag = true;
            for(int i = 0; i < len; i++)
            {
                int no = 0;
                if ((s[i]>='a' && s[i]<='z')||(s[i]>='A' && s[i] <='Z'))
                {
                    flag = true;

                }
                else
                {
                    flag = false;break;

                }
            }
            return flag;
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
            string g, sl="", s,name,date,dateAgain;
            string[] splitDate;
            bool res = false;
            Employee[] emp = new Employee[3];
            len = emp.Length;
        for (int i = 0; i < len; i++)
            {
                Console.WriteLine("\t\tPlease Enter Informaton of Employee " + (i + 1));
                Console.WriteLine("Please Enter Emp_ID");

                res = false;
                while (res == false)
                {
                    s = Console.ReadLine();
                    res = isInt(s);
                    if (res) { id = int.Parse(s); }
                    else { Console.WriteLine("Please enter Correct number"); }
                }
                do {
                Console.WriteLine("Please Enter Emp_Name");
                name = Console.ReadLine();
                    } while (!isString(name));
            
                res = false;
            while (!res)
            {
                Console.WriteLine("Please Enter Emp_Security_Level");
                Console.WriteLine("choose from Guest,Developer,Secretary,DBA");
                sl = Console.ReadLine();
                if (sl == "Guest" || sl == "Developer" || sl == "Secretary" || sl == "DBA")
                {
                    res = true;
                    Slevel = (Security_Level)Enum.Parse(typeof(Security_Level), sl);
                }
                else
                {
                    res = false;
                }
            }
                

                res = false;
            while (res == false || sal < 1200 || sal > 5000)
            {
                Console.WriteLine("Please Enter Emp_Salary");
                s = Console.ReadLine();
                res = double.TryParse(s,out sal);

            }
                
                do
                  {
                Console.WriteLine("Please Enetr Emp_HDate Like as 00/00/0000");

                date = Console.ReadLine();
                    splitDate = date.Split("/");
                    if (splitDate.Length != 3)
                    {
                        res = false;
                    }



                else {
                    
                    res = false;
                    res = int.TryParse(splitDate[0], out d);
                    res = int.TryParse(splitDate[1], out m);
                    res = int.TryParse(splitDate[2], out y);

                }
                


            } while (!res ||(d < 1 || d > 31) || (m < 1 || m > 12) || (y<1900 || y>2021) );

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
                emp[i].Name =name;
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
            Array.Sort(emp);
            //Console.Clear();
            Console.WriteLine("--------This is Information for Employees After Sorting--------");
            string result2;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("\t\tThis is Information for Employee" + (i + 1));
                result2 = emp[i].ToString();
                Console.WriteLine(result2);
                Console.WriteLine();

            }
            EmployeeSearch EMPS = new EmployeeSearch(emp);
           
            Employee tempResId, tempResDate, tempResName; string st;
            
            Date sDate = new Date();
            
            sDate.Day = 22;sDate.Month = 8;sDate.Year = 1998;
            tempResId=EMPS.searchById(3);
            st = tempResId.ToString();
            Console.WriteLine("--------Search_Result_By_ID--------");
            Console.WriteLine(st);
            Console.WriteLine();
            tempResDate = EMPS.searchByDate(sDate);
            st = tempResDate.ToString();
            Console.WriteLine("--------Search_Result_By_Hire_Date--------");
            Console.WriteLine(st);
            Console.WriteLine();
            tempResName = EMPS.searchByName("ali");
            st = tempResName.ToString();
            Console.WriteLine("--------Search_Result_By_Name--------");
            Console.WriteLine(st);
            Console.WriteLine();
        }
    }
}
