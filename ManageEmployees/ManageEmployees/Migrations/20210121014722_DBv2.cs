using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageEmployees.Migrations
{
    public partial class DBv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);    

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Department", "Image", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Phòng Kế toán", "Do-thi-chan-hoa.jpg", "Đổ Thị Chan Hòa", "012369856" },
                    { 2, "Phòng bảo vệ", "Tuan.jpg", "Phạm Tuân", "012369856" },
                    { 3, "Phòng bảo vệ", "Vu-quang-huy.jpg", "Vũ Quang Huy", "012369856" },
                    { 4, "Phòng công nghệ thông tin", "Hieu-icetea.jpg", "Nguyễn Đình Hiếu", "012369856" },
                    { 5, "Phòng quản lý", "truong-thanh-tu.jpg", "Trương Thanh Tú", "012369856" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Employees");
        }
    }
}
