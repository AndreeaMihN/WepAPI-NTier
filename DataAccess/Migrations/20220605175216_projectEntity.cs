using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A2Mac1.Costino.DataAccess.Migrations
{
    public partial class projectEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Version = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VersionReleasedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ProjectManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamMembers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearlyProducedPieces = table.Column<int>(type: "int", nullable: false),
                    ProductLifeTimeInYears = table.Column<int>(type: "int", nullable: false),
                    DepreciationTime = table.Column<int>(type: "int", nullable: false),
                    DepreciationRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsIncludedInternalLogistic = table.Column<bool>(type: "bit", nullable: false),
                    InternalLogisticRatio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShiftPerWeek = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoursPerShift = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductionDayPerWeek = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductionWeeksPerYear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BaseCurrencyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleasedToReferenceDbOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaterialOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConsumableOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ComponentsOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExternalWorkOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManufacturingOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaterialMargin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConsumableMargin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ComponentMargin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExternalWorkMargin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManufacturingMargin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCostOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PackingOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LogisticOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SgaOh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanySurcharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProjectLeaderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsibleChiefExecutive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FolderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BasedOnOhSettingId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdatedFromOhSetting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleasedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
