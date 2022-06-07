

using A2Mac1.Costino.Core.Common;

public class Project : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Number { get; set; }
    public DateTime? StartedOn { get; set; }
    public DateTime? EndedOn { get; set; }
    public decimal? Version { get; set; }
    public DateTime? VersionReleasedOn { get; set; }
    public int? StatusId { get; set; }
    public string? ProjectManager { get; set; }
    public string? TeamMembers { get; set; }
    public string? ProductName { get; set; }
    public string? ProductNumber { get; set; }
    public string? ProductDescription { get; set; }
    public int? YearlyProducedPieces { get; set; }
    public int? ProductLifeTimeInYears { get; set; }
    public int? DepreciationTime { get; set; }
    public decimal? DepreciationRatio { get; set; }
    public bool? IsIncludedInternalLogistic { get; set; }
    public decimal? InternalLogisticRatio { get; set; }
    public decimal? ShiftPerWeek { get; set; }
    public decimal? HoursPerShift { get; set; }
    public decimal? ProductionDayPerWeek { get; set; }
    public decimal? ProductionWeeksPerYear { get; set; }
    public string? BaseCurrencyId { get; set; }
    public DateTime? ReleasedToReferenceDbOn { get; set; }
    public decimal? MaterialOh { get; set; }
    public decimal? ConsumableOh { get; set; }
    public decimal? ComponentsOh { get; set; }
    public decimal? ExternalWorkOh { get; set; }
    public decimal? ManufacturingOh { get; set; }
    public decimal? MaterialMargin { get; set; }
    public decimal? ConsumableMargin { get; set; }
    public decimal? ComponentMargin { get; set; }
    public decimal? ExternalWorkMargin { get; set; }
    public decimal? ManufacturingMargin { get; set; }
    public decimal? OtherCostOh { get; set; }
    public decimal? PackingOh { get; set; }
    public decimal? LogisticOh { get; set; }
    public decimal? SgaOh { get; set; }
    public decimal? CompanySurcharge { get; set; }
    public string? ProjectLeaderId { get; set; }
    public string? ResponsibleChiefExecutive { get; set; }
    public string? FolderId { get; set; }
    public string? CompanyId { get; set; }
    public string? OwnerId { get; set; }
    public bool? IsActive { get; set; }
    public string? BasedOnOhSettingId { get; set; }
    public DateTime? LastUpdatedFromOhSetting { get; set; }
    public DateTime? DeletedOn { get; set; }
    public DateTime? ReleasedOn { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
}