using System;
using System.Collections.Generic;
using System.Text;

namespace Day09
{
    class Employee
    {
        public Employee(int id, DateTime d, int v)
        {
            EmployeeID = id;
            BirthDate = d;
            VacationStock = v;
        }
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }
        public virtual bool RequestVacation(DateTime From, DateTime To)
        {
            if ((To - From).Days < VacationStock)
            {
                return true;
            }
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.noStock });
            return false;
        }
        
        public virtual bool EndOfYearOperation()
        {
            if (2020 - BirthDate.Year >= 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.above60 });
                return false;
            }
            return true;
        }
    }
   
}
