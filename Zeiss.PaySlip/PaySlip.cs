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
        string month;
        short year;
        int basicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int profTax;
        int incomeTax;
        int loan;

        public void PrintPaySlip(string empID, string month, short year)
        {
            Console.WriteLine("PaySlip for the month of " + month + " of the year " + year.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine("With Employee ID " + empID);
            Console.WriteLine("-----------------------");
            EmployeeBL emp = new EmployeeBL();
            emp = emp.GetEmpDetails(empID);
            Console.WriteLine("For the employee " + emp.firstName+ " " + emp.lastName);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Basic Pay " + emp.Basepay);
            Console.WriteLine("-----------------------");
            Console.WriteLine("House Rent Allowance " + emp.HRA);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Dearness Allowance " + emp.DA);
            Console.WriteLine("-----------------------");
        }
    }
}
