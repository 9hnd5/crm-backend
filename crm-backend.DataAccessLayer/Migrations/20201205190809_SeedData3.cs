using Microsoft.EntityFrameworkCore.Migrations;

namespace crm_backend.DataAccessLayer.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "CreateDate", "Email", "FirstName", "LastName", "Phone", "Source", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "12/11/2020", "Tien@gmail.com", "Duong", "Tien", 445334524, "Zip", "Do not call", "15/12/2020" },
                    { 2, "1/1/2020", "Cuong@gmail.com", "Phung", "Cuong", 845334524, "rar", "New", "1/12/2020" },
                    { 3, "9/2/2020", "hoang@gmail.com", "Nguyen", "Hoang", 884334524, "rar", "Not interested in our Services", "5/12/2020" },
                    { 4, "11/2/2020", "chau@gmail.com", "Chau", "Nguyen", 931334524, "rar", "Rented Properties", "5/3/2020" },
                    { 5, "06/07/2020", "thu@gmail.com", "Thu", "Tran", 731334524, "rar", "Looking for Rental", "1/8/2020" },
                    { 11, "12/11/2020", "Tien@gmail.com", "Duong", "Tien", 445334524, "Zip", "Do not call", "15/12/2020" },
                    { 12, "1/1/2020", "Cuong@gmail.com", "Phung", "Cuong", 845334524, "rar", "New", "1/12/2020" },
                    { 13, "9/2/2020", "hoang@gmail.com", "Nguyen", "Hoang", 884334524, "rar", "Not interested in our Services", "5/12/2020" },
                    { 14, "11/2/2020", "chau@gmail.com", "Chau", "Nguyen", 931334524, "rar", "Rented Properties", "5/3/2020" },
                    { 15, "06/07/2020", "thu@gmail.com", "Thu", "Tran", 731334524, "rar", "Looking for Rental", "1/8/2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
