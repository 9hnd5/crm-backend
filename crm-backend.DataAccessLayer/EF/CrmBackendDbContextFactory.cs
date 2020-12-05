using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.DataAccessLayer.EF
{
    public class CrmBackendDbContextFactory : IDesignTimeDbContextFactory<CrmBackendDbContext>
    {
        public CrmBackendDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CrmBackendDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=crm-backend;Trusted_Connection=True;");

            return new CrmBackendDbContext(optionsBuilder.Options);
        }
    }
}
