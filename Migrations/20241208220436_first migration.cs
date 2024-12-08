using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Advanced_Frontend_Final_Api.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fname = table.Column<string>(type: "text", nullable: true),
                    lname = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    pfpurl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("person_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "temple",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    templename = table.Column<string>(type: "text", nullable: true),
                    lat = table.Column<string>(type: "text", nullable: true),
                    @long = table.Column<string>(name: "long", type: "text", nullable: true),
                    mailaddress = table.Column<string>(type: "text", nullable: true),
                    photourl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("temple_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "visit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    visittime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    note = table.Column<string>(type: "text", nullable: true),
                    personid = table.Column<int>(type: "integer", nullable: true),
                    templeid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("visit_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_person",
                        column: x => x.personid,
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_temple",
                        column: x => x.templeid,
                        principalTable: "temple",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visit_photo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    photourl = table.Column<string>(type: "text", nullable: true),
                    visitid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("visit_photo_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_visit",
                        column: x => x.visitid,
                        principalTable: "visit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_personid",
                table: "visit",
                column: "personid");

            migrationBuilder.CreateIndex(
                name: "IX_visit_templeid",
                table: "visit",
                column: "templeid");

            migrationBuilder.CreateIndex(
                name: "IX_visit_photo_visitid",
                table: "visit_photo",
                column: "visitid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visit_photo");

            migrationBuilder.DropTable(
                name: "visit");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "temple");
        }
    }
}
