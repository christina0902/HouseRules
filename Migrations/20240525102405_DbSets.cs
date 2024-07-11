using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRules.Migrations
{
    /// <inheritdoc />
    public partial class DbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChoreAssignment_Chore_ChoreId",
                table: "ChoreAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_ChoreAssignment_UserProfiles_UserProfileId",
                table: "ChoreAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_ChoreCompletion_Chore_ChoreId",
                table: "ChoreCompletion");

            migrationBuilder.DropForeignKey(
                name: "FK_ChoreCompletion_UserProfiles_UserProfileId",
                table: "ChoreCompletion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChoreCompletion",
                table: "ChoreCompletion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChoreAssignment",
                table: "ChoreAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chore",
                table: "Chore");

            migrationBuilder.RenameTable(
                name: "ChoreCompletion",
                newName: "choreCompletions");

            migrationBuilder.RenameTable(
                name: "ChoreAssignment",
                newName: "choreAssignments");

            migrationBuilder.RenameTable(
                name: "Chore",
                newName: "chores");

            migrationBuilder.RenameIndex(
                name: "IX_ChoreCompletion_UserProfileId",
                table: "choreCompletions",
                newName: "IX_choreCompletions_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_ChoreCompletion_ChoreId",
                table: "choreCompletions",
                newName: "IX_choreCompletions_ChoreId");

            migrationBuilder.RenameIndex(
                name: "IX_ChoreAssignment_UserProfileId",
                table: "choreAssignments",
                newName: "IX_choreAssignments_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_ChoreAssignment_ChoreId",
                table: "choreAssignments",
                newName: "IX_choreAssignments_ChoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_choreCompletions",
                table: "choreCompletions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_choreAssignments",
                table: "choreAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chores",
                table: "chores",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77fc8cdc-d964-4cfc-8891-3dfd39b9d681", "AQAAAAIAAYagAAAAEOeN/tEXZ1do+Oq9+PrRgCgYuxTGhCALDl5/XZpP+6oYNwhccJAMfQuZFBPcnUY5xA==", "e6e0b3b1-bb58-4609-bd60-e384abc570bd" });

            migrationBuilder.AddForeignKey(
                name: "FK_choreAssignments_UserProfiles_UserProfileId",
                table: "choreAssignments",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_choreAssignments_chores_ChoreId",
                table: "choreAssignments",
                column: "ChoreId",
                principalTable: "chores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_choreCompletions_UserProfiles_UserProfileId",
                table: "choreCompletions",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_choreCompletions_chores_ChoreId",
                table: "choreCompletions",
                column: "ChoreId",
                principalTable: "chores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_choreAssignments_UserProfiles_UserProfileId",
                table: "choreAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_choreAssignments_chores_ChoreId",
                table: "choreAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_choreCompletions_UserProfiles_UserProfileId",
                table: "choreCompletions");

            migrationBuilder.DropForeignKey(
                name: "FK_choreCompletions_chores_ChoreId",
                table: "choreCompletions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chores",
                table: "chores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_choreCompletions",
                table: "choreCompletions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_choreAssignments",
                table: "choreAssignments");

            migrationBuilder.RenameTable(
                name: "chores",
                newName: "Chore");

            migrationBuilder.RenameTable(
                name: "choreCompletions",
                newName: "ChoreCompletion");

            migrationBuilder.RenameTable(
                name: "choreAssignments",
                newName: "ChoreAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_choreCompletions_UserProfileId",
                table: "ChoreCompletion",
                newName: "IX_ChoreCompletion_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_choreCompletions_ChoreId",
                table: "ChoreCompletion",
                newName: "IX_ChoreCompletion_ChoreId");

            migrationBuilder.RenameIndex(
                name: "IX_choreAssignments_UserProfileId",
                table: "ChoreAssignment",
                newName: "IX_ChoreAssignment_UserProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_choreAssignments_ChoreId",
                table: "ChoreAssignment",
                newName: "IX_ChoreAssignment_ChoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chore",
                table: "Chore",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChoreCompletion",
                table: "ChoreCompletion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChoreAssignment",
                table: "ChoreAssignment",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162e92c1-f002-4e72-a4f1-c72249e12bfc", "AQAAAAIAAYagAAAAECUXl/JOdPpCcApcU1/6zvRqTD2+8dugf7pNhSag9uGkRmtZNeGs7XGjVvb3qmHkLQ==", "1bfdb4f1-aec3-41cc-ba09-f856e1f72af7" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreAssignment_Chore_ChoreId",
                table: "ChoreAssignment",
                column: "ChoreId",
                principalTable: "Chore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreAssignment_UserProfiles_UserProfileId",
                table: "ChoreAssignment",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreCompletion_Chore_ChoreId",
                table: "ChoreCompletion",
                column: "ChoreId",
                principalTable: "Chore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChoreCompletion_UserProfiles_UserProfileId",
                table: "ChoreCompletion",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
