using Microsoft.EntityFrameworkCore.Migrations;

namespace TAT.ToDo.DataAccess.Migrations
{
    public partial class CalismaColumnsModifiedToDoContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calismalar_Kullanicilar_KullaniciId",
                table: "Calismalar");

            migrationBuilder.DropIndex(
                name: "IX_Calismalar_KullaniciId",
                table: "Calismalar");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Calismalar");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Calismalar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklamasi",
                table: "Calismalar",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calismalar_KullanıcıId",
                table: "Calismalar",
                column: "KullanıcıId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calismalar_Kullanicilar_KullanıcıId",
                table: "Calismalar",
                column: "KullanıcıId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calismalar_Kullanicilar_KullanıcıId",
                table: "Calismalar");

            migrationBuilder.DropIndex(
                name: "IX_Calismalar_KullanıcıId",
                table: "Calismalar");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Calismalar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklamasi",
                table: "Calismalar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Calismalar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calismalar_KullaniciId",
                table: "Calismalar",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calismalar_Kullanicilar_KullaniciId",
                table: "Calismalar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
