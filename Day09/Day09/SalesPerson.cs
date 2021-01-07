using System;
using System.Collections.Generic;
using System.Text;

namespace Day09
{
   
    class SalesPerson : Employee
    {
        public SalesPerson(int id, DateTime d, int a) : base(id, d, -1) { AchievedTarget = a; }
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget >= Quota)
            {
                return true;
            }
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.target });

            return false;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.target)
                base.OnEmployeeLayOff(e);
        }
    }
}
