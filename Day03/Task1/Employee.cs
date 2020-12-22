using System;

namespace Task1
{
    public enum Gender
    {
        M, F
    }
    public struct Employee
    {
        //answer 3
        int ID, security_level;
        Date hire_date;
        double salary;
        Gender G;


        //answer 7
        public override string ToString()
        {     ///,{Enum.Parse(typeof(Gender)},
            return $"(EmpID :{ID}, EmpSL :{security_level}, EmpHD :{hire_date.ToString()}, EmpSalary {(salary):C})";
        }
        //answer 8
        public void setID(int _id)
        {
            ID = _id;
        }
        public void setSecurityLevel(int _SL)
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
            G = _g;
        }

        public int getID() { return ID; }
        public int getSecurityLevel() { return security_level; }
        public Date getHD() { return hire_date; }
        public Gender getGender() { return G; }
        public double getSalary() { return salary; }

    }
    
}