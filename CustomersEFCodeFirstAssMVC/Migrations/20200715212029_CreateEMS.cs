using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomersEFCodeFirstAssMVC.Migrations
{
    public partial class CreateEMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Cid = table.Column<string>(maxLength: 6, nullable: false),
                    Cname = table.Column<string>(maxLength: 35, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    MobileNo = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Cid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
