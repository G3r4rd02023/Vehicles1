using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_History_HistoryId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Detail_Procedures_ProcedureId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_History_AspNetUsers_UserId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Vehicle_VehicleId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_AspNetUsers_UserId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Brands_BrandId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleTypes_VehicleTypeId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePhoto_Vehicle_VehicleId",
                table: "VehiclePhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiclePhoto",
                table: "VehiclePhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_History",
                table: "History");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detail",
                table: "Detail");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "VehiclePhoto");

            migrationBuilder.RenameTable(
                name: "VehiclePhoto",
                newName: "VehiclePhotos");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "History",
                newName: "Histories");

            migrationBuilder.RenameTable(
                name: "Detail",
                newName: "Details");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclePhoto_VehicleId",
                table: "VehiclePhotos",
                newName: "IX_VehiclePhotos_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_VehicleTypeId",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_UserId",
                table: "Vehicles",
                newName: "IX_Vehicles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_BrandId",
                table: "Vehicles",
                newName: "IX_Vehicles_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_History_VehicleId",
                table: "Histories",
                newName: "IX_Histories_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_History_UserId",
                table: "Histories",
                newName: "IX_Histories_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_ProcedureId",
                table: "Details",
                newName: "IX_Details_ProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_Detail_HistoryId",
                table: "Details",
                newName: "IX_Details_HistoryId");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "VehiclePhotos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiclePhotos",
                table: "VehiclePhotos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Histories",
                table: "Histories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Plaque",
                table: "Vehicles",
                column: "Plaque",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details",
                column: "HistoryId",
                principalTable: "Histories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Vehicles_VehicleId",
                table: "Histories",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePhotos_Vehicles_VehicleId",
                table: "VehiclePhotos",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AspNetUsers_UserId",
                table: "Vehicles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Details_Histories_HistoryId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Details_Procedures_ProcedureId",
                table: "Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_AspNetUsers_UserId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Vehicles_VehicleId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePhotos_Vehicles_VehicleId",
                table: "VehiclePhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AspNetUsers_UserId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_Plaque",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiclePhotos",
                table: "VehiclePhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Histories",
                table: "Histories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "VehiclePhotos");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "VehiclePhotos",
                newName: "VehiclePhoto");

            migrationBuilder.RenameTable(
                name: "Histories",
                newName: "History");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "Detail");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicle",
                newName: "IX_Vehicle_VehicleTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicle",
                newName: "IX_Vehicle_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicle",
                newName: "IX_Vehicle_BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclePhotos_VehicleId",
                table: "VehiclePhoto",
                newName: "IX_VehiclePhoto_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_VehicleId",
                table: "History",
                newName: "IX_History_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_UserId",
                table: "History",
                newName: "IX_History_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Details_ProcedureId",
                table: "Detail",
                newName: "IX_Detail_ProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_Details_HistoryId",
                table: "Detail",
                newName: "IX_Detail_HistoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "VehiclePhoto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiclePhoto",
                table: "VehiclePhoto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_History",
                table: "History",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detail",
                table: "Detail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_History_HistoryId",
                table: "Detail",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_Procedures_ProcedureId",
                table: "Detail",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_History_AspNetUsers_UserId",
                table: "History",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Vehicle_VehicleId",
                table: "History",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_AspNetUsers_UserId",
                table: "Vehicle",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Brands_BrandId",
                table: "Vehicle",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleTypes_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePhoto_Vehicle_VehicleId",
                table: "VehiclePhoto",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
