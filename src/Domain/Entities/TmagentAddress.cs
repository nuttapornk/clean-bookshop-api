using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentAddress
{
    public long NAgentAddressId { get; set; }

    public string SAgentId { get; set; } = null!;

    public string? SAddressNo { get; set; }

    public string? SVillage { get; set; }

    public string? SAlley { get; set; }

    public string? SStreet { get; set; }

    public int? NSubDistrictId { get; set; }

    public int? NDistrictId { get; set; }

    public int? NProvinceId { get; set; }

    public string? SZipcodeId { get; set; }

    public bool BActive { get; set; }

    public bool BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
