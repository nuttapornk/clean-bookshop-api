using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentType
{
    public string SAgentTypeId { get; set; } = null!;

    public string? SAgentTypeName { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<Tmagent> Tmagents { get; } = new List<Tmagent>();
}
