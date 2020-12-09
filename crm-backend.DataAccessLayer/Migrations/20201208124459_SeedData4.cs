using Microsoft.EntityFrameworkCore.Migrations;

namespace crm_backend.DataAccessLayer.Migrations
{
    public partial class SeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/01", "2020/01/01" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/02", "2020/01/02" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/03", "2020/01/03" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/04", "2020/01/04" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/05", "2020/01/05" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/06", "2020/01/06" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/07", "2020/01/07" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/08", "2020/01/08" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/09", "2020/01/09" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/10", "2020/01/10" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/11", "2020/01/11" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/12", "2020/01/12" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/13", "2020/01/13" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/14", "2020/01/14" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "2019/01/15", "2020/01/15" });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "CreateDate", "Email", "FirstName", "LastName", "Phone", "Source", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 30, "2019/01/30", "thu@gmail.com", "Ha", "Tran", 731334524, "rar", "Looking for Rental", "2020/01/30" },
                    { 28, "2019/01/28", "hoang@gmail.com", "Chinh", "Hoang", 884334524, "rar", "Not interested in our Services", "2020/01/28" },
                    { 27, "2019/01/27", "Cuong@gmail.com", "Ngoc", "Long", 845334524, "rar", "New", "2020/01/27" },
                    { 26, "2019/01/26", "Tien@gmail.com", "Nhat", "Tien", 445334524, "Zip", "Do not call", "2020/01/26" },
                    { 25, "2019/01/25", "thu@gmail.com", "B", "Tran", 731334524, "rar", "Looking for Rental", "2020/01/25" },
                    { 24, "2019/01/24", "chau@gmail.com", "Ha", "Nguyen", 931334524, "rar", "Rented Properties", "2020/01/24" },
                    { 23, "2019/01/23", "hoang@gmail.com", "Hoang", "Nhat", 884334524, "rar", "Not interested in our Services", "2020/01/23" },
                    { 22, "2019/01/22", "Cuong@gmail.com", "Anh", "Cuong", 845334524, "rar", "New", "2020/01/22" },
                    { 21, "2019/01/21", "Tien@gmail.com", "Duong", "Tien", 445334524, "Zip", "Do not call", "2020/01/21" },
                    { 20, "2019/01/20", "thu@gmail.com", "Nguyen", "Tran", 731334524, "rar", "Looking for Rental", "2020/01/20" },
                    { 19, "2019/01/19", "chau@gmail.com", "Chau", "Long", 931334524, "rar", "Rented Properties", "2020/01/19" },
                    { 18, "2019/01/18", "hoang@gmail.com", "Chan", "Hoang", 884334524, "rar", "Not interested in our Services", "2020/01/18" },
                    { 17, "2019/01/17", "Cuong@gmail.com", "Doan", "Cuong", 845334524, "rar", "New", "2020/01/17" },
                    { 29, "2019/01/29", "chau@gmail.com", "Anh", "Nguyen", 931334524, "rar", "Rented Properties", "2020/01/29" },
                    { 16, "2019/01/16", "Tien@gmail.com", "Nguyen", "Lam", 445334524, "Zip", "Do not call", "2020/01/16" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "12/11/2020", "15/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "1/1/2020", "1/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "9/2/2020", "5/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "11/2/2020", "5/3/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "06/07/2020", "1/8/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "12/11/2020", "15/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "1/1/2020", "1/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "9/2/2020", "5/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "11/2/2020", "5/3/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "06/07/2020", "1/8/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "12/11/2020", "15/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "1/1/2020", "1/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "9/2/2020", "5/12/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "11/2/2020", "5/3/2020" });

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { "06/07/2020", "1/8/2020" });
        }
    }
}
