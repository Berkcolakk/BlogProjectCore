using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleProject.Dal.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: false),
                    CommentsID = table.Column<Guid>(nullable: false),
                    LikeID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    BlogID = table.Column<Guid>(nullable: false),
                    AppUsersID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comment_AppUser_AppUsersID",
                        column: x => x.AppUsersID,
                        principalTable: "AppUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Homepage = table.Column<bool>(nullable: false),
                    Confirmation = table.Column<bool>(nullable: false),
                    ReadNumber = table.Column<int>(nullable: false),
                    AppUserID = table.Column<Guid>(nullable: true),
                    UsersID = table.Column<Guid>(nullable: false),
                    CategoryID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Blog_AppUser_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blog_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    BlogID = table.Column<Guid>(nullable: false),
                    CommentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlogComment_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComment_Comment_CommentID",
                        column: x => x.CommentID,
                        principalTable: "Comment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIp = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedADUserName = table.Column<string>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIp = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModifiedADUserName = table.Column<string>(nullable: true),
                    AppUserID = table.Column<Guid>(nullable: false),
                    BlogID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Like_AppUser_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Like_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_AppUserID",
                table: "Blog",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryID",
                table: "Blog",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_BlogID",
                table: "BlogComment",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_CommentID",
                table: "BlogComment",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUsersID",
                table: "Comment",
                column: "AppUsersID");

            migrationBuilder.CreateIndex(
                name: "IX_Like_AppUserID",
                table: "Like",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Like_BlogID",
                table: "Like",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComment");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
