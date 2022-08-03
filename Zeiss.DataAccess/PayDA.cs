using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.DataAccess
{
    public class PayDA
    {
        public int GetBasicPay(string empID, Int16 month, Int16 year)
        {
            //connect to database
            //execute stored procedure/query
            //get Basic pay
            //close connection
            return 20000; //Basic pay
        }
    }
    public class EmployeeDA
    {
        public string empID;
        public string firstName;
        public string lastName;
        public string DOJ;

        public EmployeeDA GetEmployeeDetails(string empID)
        {
            EmployeeDA emp = new EmployeeDA();
            emp.firstName = "Ram";
            emp.lastName = "Raj";
            emp.DOJ = "25-07-22";
            return emp;
        }
    }
}
