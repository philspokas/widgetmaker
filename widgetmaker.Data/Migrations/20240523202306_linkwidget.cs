using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace widgetmaker.Data.Migrations
{
    /// <inheritdoc />
    public partial class linkwidget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WidgetId",
                table: "Inventories",
                column: "WidgetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Widgets_WidgetId",
                table: "Inventories",
                column: "WidgetId",
                principalTable: "Widgets",
                principalColumn: "WidgetId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Widgets_WidgetId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_WidgetId",
                table: "Inventories");
        }
    }
}
