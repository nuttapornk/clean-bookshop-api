using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentProfileType
{
    public string SAgentProfileTypeId { get; set; } = null!;

    public string SAgentProfileTypeName { get; set; } = null!;

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TtverifyProfileAgent> TtverifyProfileAgents { get; } = new List<TtverifyProfileAgent>();
}
