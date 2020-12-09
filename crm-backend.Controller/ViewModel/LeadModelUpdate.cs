using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crm_backend.Controller.ViewModel
{
    public class LeadModelUpdate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Please enter the correct email")]
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
