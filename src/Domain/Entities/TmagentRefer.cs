using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentRefer
{
    public string SAgentReferId { get; set; } = null!;

    public string SAgentReferGroup { get; set; } = null!;

    public string SAgentParentId { get; set; } = null!;

    public string SAgentChildId { get; set; } = null!;

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<Tmagent> Tmagents { get; } = new List<Tmagent>();
}
