using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.DataAccess;

namespace Zeiss.BL
{
    public class PayBL
    {
        public int GetBasicPay(string empID, Int16 month, Int16 year)
        {
            PayDA PayDa = new PayDA();
            int basicPay = PayDa.GetBasicPay(empID, month, year);
            return basicPay;
        }
        public int CalculateDA(string empID, Int16 month, Int16 year)
        {
            int basicPay = GetBasicPay(empID, month, year);
            int da = 0;
            if (basicPay > 25000)
            {
                da = basicPay * 30/100;
            }
            else
            {
                da = basicPay * 40/100;
            }
            return da;
        }
        public int CalculateHRA(string empID, Int16 month, Int16 year)
        {
            int basicPay = GetBasicPay(empID, month, year);
            int hra = 0;
            hra = basicPay * 50 / 100;
            return hra;
        }
    }
    public class EmployeeBL
    {
        public string empId;
        public string firstName;
        public string lastName;
        public string DOJ;

        public EmployeeBL GetEmpDetails(string empID)
        {
            EmployeeDA empD1 = new EmployeeDA();
            empD1 = empD1.GetEmployeeDetails(empID);

            EmployeeBL empB1 = new EmployeeBL();
            empB1.empId = empD1.empID;
            empB1.firstName = empD1.firstName;
            empB1.lastName = empD1.lastName;
            empB1.DOJ = empD1.DOJ;

            return empB1;

        }
    }
}
