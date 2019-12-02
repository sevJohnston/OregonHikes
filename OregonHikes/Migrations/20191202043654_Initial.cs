using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace OregonHikes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hikes",
                columns: table => new
                {
                    HikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrailName = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HikeID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hikes", x => x.HikeID);
                    table.ForeignKey(
                        name: "FK_Hikes_Hikes_HikeID1",
                        column: x => x.HikeID1,
                        principalTable: "Hikes",
                        principalColumn: "HikeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PeopleName = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PersonID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_People_People_PersonID1",
                        column: x => x.PersonID1,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    UserReviewID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserNameUserID = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    HikeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.UserReviewID);
                    table.ForeignKey(
                        name: "FK_UserReviews_Hikes_HikeID",
                        column: x => x.HikeID,
                        principalTable: "Hikes",
                        principalColumn: "HikeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserReviews_Users_UserNameUserID",
                        column: x => x.UserNameUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hikes_HikeID1",
                table: "Hikes",
                column: "HikeID1");

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonID1",
                table: "People",
                column: "PersonID1");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_HikeID",
                table: "UserReviews",
                column: "HikeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserNameUserID",
                table: "UserReviews",
                column: "UserNameUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "Hikes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
