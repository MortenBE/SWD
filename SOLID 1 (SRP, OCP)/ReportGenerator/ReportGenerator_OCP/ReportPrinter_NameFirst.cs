﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator_OCP
{
    class ReportPrinter_NameFirst : IReportPrinter
    {
        public void printReport(List<Employee> employees)
        {
            Console.WriteLine("Name-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Age: {0}", e.Age);
                Console.WriteLine("------------------");
            }
        }
    }
}
