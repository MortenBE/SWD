using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ReportGenerator_OCP
{
    internal interface IReportPrinter
    {
        void printReport(List<Employee> employees);
    }
}
