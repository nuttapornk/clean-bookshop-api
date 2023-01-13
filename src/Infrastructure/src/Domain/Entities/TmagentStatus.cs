using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentStatus
{
    public string SAgentStatusId { get; set; } = null!;

    public string? SAgentStatusName { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<Tmagent> Tmagents { get; } = new List<Tmagent>();
}
