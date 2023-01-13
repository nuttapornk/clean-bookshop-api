using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmverifyRejectDetail
{
    public long NVerifyRejectDetailId { get; set; }

    public string SAgentId { get; set; } = null!;

    public bool? BInvalidCitizen { get; set; }

    public bool? BInvalidLicenseNo { get; set; }

    public bool? BInvalidBankAccount { get; set; }

    public bool? BInvalidAddress { get; set; }

    public bool? BInvalidSelfie { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
