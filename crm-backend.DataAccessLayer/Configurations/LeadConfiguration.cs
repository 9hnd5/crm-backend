using crm_backend.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace crm_backend.DataAccessLayer.Configurations
{
    public class LeadConfiguration : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.ToTable("Leads");
            builder.HasKey(x => x.Id);
            builder.Property<string>(x => x.FirstName);
            builder.Property<string>(x => x.LastName);
            builder.Property<string>(x => x.Email);
            builder.Property<int>(x => x.Phone);
            builder.Property<string>(x => x.Source);
            builder.Property<string>(x => x.Status);
            builder.Property<string>(x => x.CreateDate);
            builder.Property<string>(x => x.UpdateDate);
        }
    }
}
