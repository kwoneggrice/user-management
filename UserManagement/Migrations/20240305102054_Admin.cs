using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagement.Migrations
{
	/// <inheritdoc />
	public partial class Admin : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Admins",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
					AdminId = table.Column<string>(type: "varchar(255)", nullable: false)
						.Annotation("MySql:CharSet", "utf8mb4"),
					Password = table.Column<string>(type: "longtext", nullable: false)
						.Annotation("MySql:CharSet", "utf8mb4")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Admins", x => x.Id);
				})
				.Annotation("MySql:CharSet", "utf8mb4");

			migrationBuilder.CreateIndex(
				name: "IX_Admins_AdminId",
				table: "Admins",
				column: "AdminId",
				unique: true);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Admins");
		}
	}
}
