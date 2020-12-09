using crm_backend.DataAccessLayer.EF;
using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crm_backend.Repository.Implement
{
    public class LeadRepository : ILeadRepository
    {
        private readonly CrmBackendDbContext _context;
        private readonly IBaseRepository<Lead> _baseRepository;
        public LeadRepository(CrmBackendDbContext context, IBaseRepository<Lead> baseRepository)
        {
            _context = context;
            _baseRepository = baseRepository;
        }
        public List<Lead> Paging(int pageIndex, int pageSize)
        {
            // Query all lead
            var leads = (from lead in _context.Leads
                         select lead).ToList();
            //Paging
            var result = leads.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return result;
        }
        public List<Lead> GetLeads(int index, int size)
        {
            var leads = (from lead in _context.Leads
                         select lead).Skip((index - 1) * size).Take(size).ToList();
            return leads;
        }
        public List<Lead> ReportLeadByDate(string from, string to)
        {
            var leads = _context.Leads.FromSqlRaw("Execute dbo.sp_fillter_lead_by_range_date {0}, {1}", from, to).ToList();
            return leads;
        }
        public Object ReportLeadByStatus()
        {
            var leadsFromDB = (from lead in _context.Leads
                               select lead).ToList();
            List<KeyValuePair<string, int>> groupLeadByStatus = (from lead in leadsFromDB
                                     group lead by lead.Status into leadGroup
                                     select leadGroup).ToDictionary(x => x.Key, x => x.ToList().Count()).ToList();
            return groupLeadByStatus;
        }
    }
}
