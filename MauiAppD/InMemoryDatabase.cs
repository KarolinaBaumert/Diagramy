using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppD
{
    class InMemoryDatabase
    {
        public static List<ReportData> ReportDataTable { get; } = new List<ReportData>();
    }
}
