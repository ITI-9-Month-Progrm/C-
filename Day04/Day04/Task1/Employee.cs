using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    enum Gender { M,F}
    [Flags] //to handle MultiValue in Enum
    enum Security_Level:Byte {
        Guest=8,Developer = 4,  Secretary = 2 ,DBA= 1//, security_privileges=15
    }
    struct Employee:IComparable
    {
        int id;
        string name;
        Security_Level security_level;
        double salary;
        Date hire_date;
        Gender type;
        
        public override string ToString()
        {     ///,{Enum.Parse(typeof(Gender)},
            return $"(EmpName : {name} , EmpID :{id}, EmpSL :{security_level}, EmpHD :{hire_date.ToString()}, EmpSalary {(salary):C})";
        }

        //answer 9
        public void setID(int _id)
        {
            id = _id;
        }
        public void setSecurityLevel(Security_Level _SL)
        {
            security_level = _SL;
        }
        public void setHD(Date _HD)
        {
            hire_date = _HD;
        }
        public void setSalary(double _salary)
        {
            salary = _salary;
        }
        public void setGender(Gender _g)
        {
            type = _g;
        }

        public int getID() { return id; }
        public Security_Level getSecurityLevel() { return security_level; }
        public Date getHD() { return hire_date; }
        public Gender getGender() { return type; }
        public double getSalary() { return salary; }

        /// answer 16
        public int Id
        {
            set { id = value; }
            get { return id; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Security_Level SecurityLevel
        {
            set { security_level = value; }
            get { return security_level; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public Gender Type
        {
            set { type = value; }
            get { return type; }
        }
        public Date Hire_Date
        {
            set { hire_date = value; }
            get { return hire_date; }
        }
        public int CompareTo(object obj)
        {
            Employee empRight = (Employee) obj;
            if (empRight.hire_date.Year == hire_date.Year)
            {
                if(empRight.hire_date.Month == hire_date.Month)
                {
                    return hire_date.Day.CompareTo(empRight.hire_date.Day);
                }
                else { return hire_date.Month.CompareTo(empRight.hire_date.Month); }
            }
            else { return hire_date.Year.CompareTo(empRight.hire_date.Year); }

        }
            

    }
}
