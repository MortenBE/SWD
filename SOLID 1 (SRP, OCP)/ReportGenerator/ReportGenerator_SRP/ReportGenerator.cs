using System;
using System.Collections.Generic;

namespace ReportGenerator_SRP
{


    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        
        private int _format;


        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
        }


        public void CompileReport(ReportPrinter myReportPrinter)
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            
            //Printer class is now responsible of printing the report
            myReportPrinter.printReport(employees);

        }

    }
}