using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentClass
{
    public string SAgentClassId { get; set; } = null!;

    public string? SAgentClassName { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateUy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<Tmagent> Tmagents { get; } = new List<Tmagent>();
}
