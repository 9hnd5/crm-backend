using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Implement;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.Repository.Interface
{
    public interface ILeadRepository
    {
        public List<Lead> GetLeads(int index, int size);
        public Object ReportLeadByStatus();
        public List<Lead> ReportLeadByDate(string from, string to);
        public List<Lead> Paging(int pageIndex, int pageSize);
    }
}
