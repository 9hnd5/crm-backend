using crm_backend.DataAccessLayer.EF;
using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crm_backend.Repository.Implement
{
    public class LeadRepository : ILeadRepository
    {
        private readonly CrmBackendDbContext _context;
        public LeadRepository(CrmBackendDbContext context)
        {
            _context = context;
        }
        public List<Lead> GetAllLead()
        {
            var leads = _context.Leads.ToList();
            return leads;
        }

        public Lead GetLeadById(int id)
        {
            Lead lead = (from l in _context.Leads
                         where l.Id == id
                         select l).SingleOrDefault();
            return lead;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateLeadById(int id, Lead lead)
        {
            var oldLead = (from l in _context.Leads
                    where l.Id == id
                    select l).SingleOrDefault();
            oldLead.FirstName = lead.FirstName;
            oldLead.LastName = lead.LastName;
            oldLead.Email = lead.Email;
            oldLead.Phone = lead.Phone;
            oldLead.Source = lead.Source;
            oldLead.Status = lead.Status;
            oldLead.CreateDate = lead.CreateDate;
            oldLead.UpdateDate = lead.UpdateDate;
        }
    }
}
