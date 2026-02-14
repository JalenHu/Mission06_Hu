using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Hu.Migrations
{
    /// <inheritdoc />
    public partial class MakeLenToOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lentto",
                table: "Movies",
                newName: "LentTo");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Movies",
                type: "TEXT",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "LentTo",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LentTo",
                table: "Movies",
                newName: "Lentto");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Movies",
                type: "TEXT",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lentto",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
