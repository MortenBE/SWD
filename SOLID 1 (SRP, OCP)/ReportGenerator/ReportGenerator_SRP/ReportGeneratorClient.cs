using System;

namespace ReportGenerator_SRP
{
    class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new Employee("Christel", 1000));

            //Create report generator
            var reportGenerator = new ReportGenerator(db);

            //Create Name-First report printer
            IReportPrinter myNameFirstReportPrinter = new PrintReport_NameFirst();
            //Create Salery-First report printer
            IReportPrinter mySaleryFirstReportPrinter = new PrintReport_SaleryFirst();

            // Compile report with Name-First report printer
            reportGenerator.CompileReport(myNameFirstReportPrinter);

            Console.WriteLine("");
            Console.WriteLine("");

            //Compile report with Salery-First report printer
            reportGenerator.CompileReport(mySaleryFirstReportPrinter);

        }
    }
}