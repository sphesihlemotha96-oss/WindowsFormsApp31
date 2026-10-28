using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp31
{
    internal class employee
    {
     public int hoursWorked, hourlyRate;
       double uif = 0.085;
        double medicalAid = 0.065;
        double pension = 0.078;
    
     public double salary, deductions=0.00;
        public double calcSalary()
        {
            salary = hoursWorked * hourlyRate;
            return salary;
        }
        public double calcDeductuctions()
        {
            uif = salary * uif;
            medicalAid = salary * medicalAid;
            pension = salary *pension;
            deductions = uif + medicalAid + pension;
            return deductions;
        }
    }
}
