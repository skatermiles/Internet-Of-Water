using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waterSystem.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public int TypeID { get; set; }
        public string Subject { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}