using System;
using System.Collections.Generic;
using System.Text;

namespace Day09
{
    class BoardMember : Employee
    {
        public BoardMember(int id, DateTime d) : base(id, d, -1) { }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.resign });
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.resign)
                base.OnEmployeeLayOff(e);
        }
    }
}
