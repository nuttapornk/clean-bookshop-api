using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentCodeMapping
{
    public long NRunningNo { get; set; }

    public string SAgentId { get; set; } = null!;

    public string SAgentCode { get; set; } = null!;

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
