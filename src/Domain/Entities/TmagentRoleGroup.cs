using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentRoleGroup
{
    public string SAgentRoleGroupId { get; set; } = null!;

    public string? SAgentRoleGroupName { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TmagentRole> TmagentRoles { get; } = new List<TmagentRole>();
}
