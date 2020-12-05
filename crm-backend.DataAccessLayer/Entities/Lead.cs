using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.DataAccessLayer.Entities
{
    public class Lead
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
