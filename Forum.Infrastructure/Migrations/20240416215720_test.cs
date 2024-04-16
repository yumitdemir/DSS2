using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Forum.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Topic_TopicId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_users_CreatorId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_users_CreatorId",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_CreatorId",
                table: "Topics",
                newName: "IX_Topics_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_TopicId",
                table: "Comments",
                newName: "IX_Comments_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_CreatorId",
                table: "Comments",
                newName: "IX_Comments_CreatorId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Topics",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Comments",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Topics_TopicId",
                table: "Comments",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_users_CreatorId",
                table: "Comments",
                column: "CreatorId",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_users_CreatorId",
                table: "Topics",
                column: "CreatorId",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Topics_TopicId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_users_CreatorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_users_CreatorId",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_CreatorId",
                table: "Topic",
                newName: "IX_Topic_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_TopicId",
                table: "Comment",
                newName: "IX_Comment_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_CreatorId",
                table: "Comment",
                newName: "IX_Comment_CreatorId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Topic",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Comment",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Topic_TopicId",
                table: "Comment",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_users_CreatorId",
                table: "Comment",
                column: "CreatorId",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_users_CreatorId",
                table: "Topic",
                column: "CreatorId",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
