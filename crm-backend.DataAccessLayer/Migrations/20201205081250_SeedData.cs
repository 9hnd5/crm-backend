using Microsoft.EntityFrameworkCore.Migrations;

namespace crm_backend.DataAccessLayer.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "CreateDate", "Email", "FirstName", "LastName", "Phone", "Source", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "10/11/2020", "ng.d.huy95@gmail.com", "Nguyen", "Huy", 945334524, "Zip", "Do not call", "15/11/2020" },
                    { 2, "10/1/2020", "abc@gmail.com", "Tran", "Long", 545334524, "rar", "New", "1/11/2020" },
                    { 3, "9/2/2020", "hoa@gmail.com", "Hoa", "Nguyen", 234334524, "rar", "Not interested in our Services", "5/12/2020" },
                    { 4, "11/2/2020", "chau@gmail.com", "Chau", "Nguyen", 931334524, "rar", "Rented Properties", "5/3/2020" },
                    { 5, "06/07/2020", "thu@gmail.com", "Thu", "Tran", 731334524, "rar", "Looking for Rental", "1/8/2020" }
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
        }
    }
}
