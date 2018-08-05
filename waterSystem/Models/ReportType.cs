using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waterSystem.Models
{
    public class ReportType
    {
        public int TypeId { get; set; }
        public int UserID { get; set; }
        public int Heading { get; set; }
        public int Description { get; set; }
    }
}