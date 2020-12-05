using crm_backend.DataAccessLayer.Configurations;
using crm_backend.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.DataAccessLayer.EF
{
    public class CrmBackendDbContext: DbContext
    {
        public CrmBackendDbContext(DbContextOptions option): base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LeadConfiguration());
        }
        public DbSet<Lead> Leads { get; set; }
    }
}
