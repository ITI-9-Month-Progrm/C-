using System;
using System.Collections.Generic;
using System.Text;

namespace Day09
{
    class Club
    {
        public Club(int id, string name)
        {
            ClubID = id;
            ClubName = name;
        }
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee em)
            {

                if (e.Cause == LayOffCause.noStock || e.Cause == LayOffCause.target)
                {
                    Members.Remove(em);
                    em.EmployeeLayOff -= RemoveMember;

                }
            }
        }
    }
}
