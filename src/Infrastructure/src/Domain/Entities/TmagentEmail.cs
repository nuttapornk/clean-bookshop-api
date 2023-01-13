using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentEmail
{
    public long NAgentEmailId { get; set; }

    public string SAgentId { get; set; } = null!;

    public string? SEmail { get; set; }

    public bool? BIsActive { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;
}
