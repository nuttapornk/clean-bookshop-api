using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentReasonDisable
{
    public string SAgentReasonDisable { get; set; } = null!;

    public string SAgentId { get; set; } = null!;

    public string? SRemark { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
