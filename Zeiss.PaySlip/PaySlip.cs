using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.PaySlip
{ 
    public class PaySlip
    {
        string empID;
        string empFirstName;
        string empLastName;
        string department;
        DateTime DOJ;
        short month;
        short year;
        int basicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int profTax;
        int incomeTax;
        int loan;

        public void PrintPaySlip(string empID, short month, short year)
        {
            Console.WriteLine("PaySlip for " + month.ToString() + " - " + year.ToString());
            Console.WriteLine(empID);
            EmployeeBL emp = new EmployeeBL();
            emp = emp.GetEmpDetails(empID);
            Console.WriteLine(emp.empId+ " " + emp.firstName+ " " + emp.lastName);
        }
    }
}
