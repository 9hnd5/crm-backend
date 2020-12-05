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
            modelBuilder.Entity<Lead>().HasData(
                new Lead
                {
                    Id = 1,
                    FirstName = "Duong",
                    LastName = "Tien",
                    Email = "Tien@gmail.com",
                    Phone = 0445334524,
                    Source = "Zip",
                    Status = "Do not call",
                    CreateDate = "12/11/2020",
                    UpdateDate = "15/12/2020"
                },
                new Lead
                {
                    Id = 2,
                    FirstName = "Phung",
                    LastName = "Cuong",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "1/1/2020",
                    UpdateDate = "1/12/2020"
                },
                new Lead
                {
                    Id = 3,
                    FirstName = "Nguyen",
                    LastName = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "9/2/2020",
                    UpdateDate = "5/12/2020"
                },
                new Lead
                {
                    Id = 4,
                    FirstName = "Chau",
                    LastName = "Nguyen",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "11/2/2020",
                    UpdateDate = "5/3/2020"
                },
                new Lead
                {
                    Id = 5,
                    FirstName = "Thu",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "06/07/2020",
                    UpdateDate = "1/8/2020"
                },
                new Lead
                {
                    Id = 6,
                    FirstName = "Duong",
                    LastName = "Tien",
                    Email = "Tien@gmail.com",
                    Phone = 0445334524,
                    Source = "Zip",
                    Status = "Do not call",
                    CreateDate = "12/11/2020",
                    UpdateDate = "15/12/2020"
                },
                new Lead
                {
                    Id = 7,
                    FirstName = "Phung",
                    LastName = "Cuong",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "1/1/2020",
                    UpdateDate = "1/12/2020"
                },
                new Lead
                {
                    Id = 8,
                    FirstName = "Nguyen",
                    LastName = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "9/2/2020",
                    UpdateDate = "5/12/2020"
                },
                new Lead
                {
                    Id = 9,
                    FirstName = "Chau",
                    LastName = "Nguyen",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "11/2/2020",
                    UpdateDate = "5/3/2020"
                },
                new Lead
                {
                    Id = 10,
                    FirstName = "Thu",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "06/07/2020",
                    UpdateDate = "1/8/2020"
                },
                new Lead
                {
                    Id = 11,
                    FirstName = "Duong",
                    LastName = "Tien",
                    Email = "Tien@gmail.com",
                    Phone = 0445334524,
                    Source = "Zip",
                    Status = "Do not call",
                    CreateDate = "12/11/2020",
                    UpdateDate = "15/12/2020"
                },
                new Lead
                {
                    Id = 12,
                    FirstName = "Phung",
                    LastName = "Cuong",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "1/1/2020",
                    UpdateDate = "1/12/2020"
                },
                new Lead
                {
                    Id = 13,
                    FirstName = "Nguyen",
                    LastName = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "9/2/2020",
                    UpdateDate = "5/12/2020"
                },
                new Lead
                {
                    Id = 14,
                    FirstName = "Chau",
                    LastName = "Nguyen",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "11/2/2020",
                    UpdateDate = "5/3/2020"
                },
                new Lead
                {
                    Id = 15,
                    FirstName = "Thu",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "06/07/2020",
                    UpdateDate = "1/8/2020"
                }
            );
        }
        public DbSet<Lead> Leads { get; set; }
    }
}
