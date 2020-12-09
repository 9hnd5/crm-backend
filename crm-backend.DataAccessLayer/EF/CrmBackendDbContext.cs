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
                    CreateDate = "2019/01/01",
                    UpdateDate = "2020/01/01"
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
                    CreateDate = "2019/01/02",
                    UpdateDate = "2020/01/02"
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
                    CreateDate = "2019/01/03",
                    UpdateDate = "2020/01/03"
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
                    CreateDate = "2019/01/04",
                    UpdateDate = "2020/01/04"
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
                    CreateDate = "2019/01/05",
                    UpdateDate = "2020/01/05"
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
                    CreateDate = "2019/01/06",
                    UpdateDate = "2020/01/06"
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
                    CreateDate = "2019/01/07",
                    UpdateDate = "2020/01/07"
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
                    CreateDate = "2019/01/08",
                    UpdateDate = "2020/01/08"
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
                    CreateDate = "2019/01/09",
                    UpdateDate = "2020/01/09"
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
                    CreateDate = "2019/01/10",
                    UpdateDate = "2020/01/10"
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
                    CreateDate = "2019/01/11",
                    UpdateDate = "2020/01/11"
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
                    CreateDate = "2019/01/12",
                    UpdateDate = "2020/01/12"
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
                    CreateDate = "2019/01/13",
                    UpdateDate = "2020/01/13"
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
                    CreateDate = "2019/01/14",
                    UpdateDate = "2020/01/14"
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
                    CreateDate = "2019/01/15",
                    UpdateDate = "2020/01/15"
                },


                 new Lead
                 {
                     Id = 16,
                     FirstName = "Nguyen",
                     LastName = "Lam",
                     Email = "Tien@gmail.com",
                     Phone = 0445334524,
                     Source = "Zip",
                     Status = "Do not call",
                     CreateDate = "2019/01/16",
                     UpdateDate = "2020/01/16"
                 },
                new Lead
                {
                    Id = 17,
                    FirstName = "Doan",
                    LastName = "Cuong",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "2019/01/17",
                    UpdateDate = "2020/01/17"
                },
                new Lead
                {
                    Id = 18,
                    FirstName = "Chan",
                    LastName = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "2019/01/18",
                    UpdateDate = "2020/01/18"
                },
                new Lead
                {
                    Id = 19,
                    FirstName = "Chau",
                    LastName = "Long",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "2019/01/19",
                    UpdateDate = "2020/01/19"
                },
                new Lead
                {
                    Id = 20,
                    FirstName = "Nguyen",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "2019/01/20",
                    UpdateDate = "2020/01/20"
                },
                new Lead
                {
                    Id = 21,
                    FirstName = "Duong",
                    LastName = "Tien",
                    Email = "Tien@gmail.com",
                    Phone = 0445334524,
                    Source = "Zip",
                    Status = "Do not call",
                    CreateDate = "2019/01/21",
                    UpdateDate = "2020/01/21"
                },
                new Lead
                {
                    Id = 22,
                    FirstName = "Anh",
                    LastName = "Cuong",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "2019/01/22",
                    UpdateDate = "2020/01/22"
                },
                new Lead
                {
                    Id = 23,
                    FirstName = "Hoang",
                    LastName = "Nhat",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "2019/01/23",
                    UpdateDate = "2020/01/23"
                },
                new Lead
                {
                    Id = 24,
                    FirstName = "Ha",
                    LastName = "Nguyen",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "2019/01/24",
                    UpdateDate = "2020/01/24"
                },
                new Lead
                {
                    Id = 25,
                    FirstName = "B",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "2019/01/25",
                    UpdateDate = "2020/01/25"
                },
                new Lead
                {
                    Id = 26,
                    FirstName = "Nhat",
                    LastName = "Tien",
                    Email = "Tien@gmail.com",
                    Phone = 0445334524,
                    Source = "Zip",
                    Status = "Do not call",
                    CreateDate = "2019/01/26",
                    UpdateDate = "2020/01/26"
                },
                new Lead
                {
                    Id = 27,
                    FirstName = "Ngoc",
                    LastName = "Long",
                    Email = "Cuong@gmail.com",
                    Phone = 0845334524,
                    Source = "rar",
                    Status = "New",
                    CreateDate = "2019/01/27",
                    UpdateDate = "2020/01/27"
                },
                new Lead
                {
                    Id = 28,
                    FirstName = "Chinh",
                    LastName = "Hoang",
                    Email = "hoang@gmail.com",
                    Phone = 0884334524,
                    Source = "rar",
                    Status = "Not interested in our Services",
                    CreateDate = "2019/01/28",
                    UpdateDate = "2020/01/28"
                },
                new Lead
                {
                    Id = 29,
                    FirstName = "Anh",
                    LastName = "Nguyen",
                    Email = "chau@gmail.com",
                    Phone = 0931334524,
                    Source = "rar",
                    Status = "Rented Properties",
                    CreateDate = "2019/01/29",
                    UpdateDate = "2020/01/29"
                },
                new Lead
                {
                    Id = 30,
                    FirstName = "Ha",
                    LastName = "Tran",
                    Email = "thu@gmail.com",
                    Phone = 0731334524,
                    Source = "rar",
                    Status = "Looking for Rental",
                    CreateDate = "2019/01/30",
                    UpdateDate = "2020/01/30"
                }
                );
        }
        public DbSet<Lead> Leads { get; set; }
    }
}
