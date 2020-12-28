using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class EmployeeSearch
    {
        public Employee[] empSearch;
        public EmployeeSearch(Employee [] empMain)
        {
            empSearch = empMain;
        }

        //Bubble Sort
       public void sortByID()
        {
            int len;
            len = empSearch.Length;
            Employee temp;

            for(int i = 0; i < len-1; i++)
            {
                for(int j = 0; j < len - 2; j++)
                {
                    if(empSearch[i].Id > empSearch[j + 1].Id)
                    {
                        temp = empSearch[i];
                        empSearch[i]=empSearch[j+1];
                        empSearch[j + 1] = temp;
                    }
                }
            }
        }
        //Binary Search
        public Employee searchById(int idSearch)
        {
            sortByID();
            int len,left, right, mid=0;
            len = empSearch.Length;
            left = 0;right = len - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (idSearch == empSearch[mid].Id) { mid++;break; }
                else if (idSearch > empSearch[mid].Id){ left = mid + 1; }
                else{right = mid - 1;}
            }
            mid--;
                return empSearch[mid];
            }
        public Employee searchByDate(Date dateSearch)
        {
            Array.Sort(empSearch);
            int len, left, right, mid = 0;
            len = empSearch.Length;
            left = 0; right = len - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if ((dateSearch.Year== empSearch[mid].Hire_Date.Year) && (dateSearch.Month == empSearch[mid].Hire_Date.Month) &&(dateSearch.Day == empSearch[mid].Hire_Date.Day)) 
                { mid++; break; }
                else if ((dateSearch.Year > empSearch[mid].Hire_Date.Year) && (dateSearch.Month > empSearch[mid].Hire_Date.Month) && (dateSearch.Day > empSearch[mid].Hire_Date.Day)) { left = mid + 1; }
                else { right = mid - 1; }
            }
            mid--;
            return empSearch[mid];
        }

        //sequensial search
        public Employee searchByName(string sName)
        {
            int len,res=0;len = empSearch.Length;
            bool flag;
            flag = false;
            for(int i = 0; i < len; i++) { 
                if(sName == empSearch[i].Name)
                {
                    res = i;
                    flag = true;break;
                }
            }
            return empSearch[res];       
        }
    }
}
