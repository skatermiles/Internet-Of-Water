using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace waterSystem.Models
{
    public class User

    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        private string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Cellphone { get; set; }
        private string Email { get; set; }
        private string Country { get; set; }
        private string City { get; set; }
        private string Suburb { get; set; }

        public virtual ICollection<ReportType> ReportTypes { get; set; }
    }
}