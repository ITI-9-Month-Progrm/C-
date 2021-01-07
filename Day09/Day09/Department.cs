using System;
using System.Collections.Generic;
using System.Text;

namespace Day09
{
    class Department
    {
        public Department(int id, string name)
        {
            DeptID = id;
            DeptName = name;
        }
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee E)
        {
            E.EmployeeLayOff += RemoveStaff;
            Staff.Add(E);



            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee em)
            {

                if (e.Cause == LayOffCause.above60 || e.Cause == LayOffCause.noStock || e.Cause == LayOffCause.resign || e.Cause == LayOffCause.target)
                {
                    Staff.Remove(em);
                    em.EmployeeLayOff -= RemoveStaff;

                }
            }

        }
    }
}
