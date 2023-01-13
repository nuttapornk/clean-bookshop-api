using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentLicense
{
    public long NLicenseId { get; set; }

    public string SAgentId { get; set; } = null!;

    public string SLicenseNo { get; set; } = null!;

    public DateTime? DLicenseExpiredDate { get; set; }

    public bool BActive { get; set; }

    public bool BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? LastCheckedLicenseStatus { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
