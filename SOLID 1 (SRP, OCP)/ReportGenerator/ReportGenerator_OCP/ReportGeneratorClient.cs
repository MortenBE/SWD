using System;

namespace ReportGenerator_OCP
{
    class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000, 34));
            db.AddEmployee(new Employee("Berit", 2000, 40));
            db.AddEmployee(new Employee("Christel", 1000,29));

            //Create report generator
            var reportGenerator = new ReportGenerator(db);

            //Create Name-First report printer
            IReportPrinter myNameFirstReportPrinter = new ReportPrinter_NameFirst();
            //Create Salery-First report printer
            IReportPrinter mySaleryFirstReportPrinter = new ReportPrinter_SaleryFirst();
            //Create Salery-First report printer
            IReportPrinter myAgeFirstReportPrinter = new ReportPrinter_AgeFirst();

            // Compile report with Name-First report printer
            reportGenerator.CompileReport(myNameFirstReportPrinter);

            Console.WriteLine("");
            Console.WriteLine("");

            //Compile report with Salery-First report printer
            reportGenerator.CompileReport(mySaleryFirstReportPrinter);

            Console.WriteLine("");
            Console.WriteLine("");

            //Compile report with Salery-First report printer
            reportGenerator.CompileReport(myAgeFirstReportPrinter);

        }
    }
}