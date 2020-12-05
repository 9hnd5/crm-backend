using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Implement;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.Repository.Interface
{
    public interface ILeadRepository
    {
        public List<Lead> GetAllLead();
        public void UpdateLeadById(int id, Lead lead);
        public Lead GetLeadById(int id);
        public void SaveChanges();

    }
}
