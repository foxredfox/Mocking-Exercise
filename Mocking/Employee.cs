using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class Employee 
    {
        public int Id {get; set;}
        public String Name {get; set;}
        public String Type {get; set;}
        public double Wage {get; set;}

        public MailBox MailBox {get; set;}
        
        public double CalculateWeeklySalary(int h, double w)
        {
            return h * w;
        }

        public double CalculateWeeklyAverageSalary(int h, int q)
        {
            return (h * Wage) / q;
        }
    }
}
