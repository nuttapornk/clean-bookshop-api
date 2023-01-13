using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TempTmagentRole
{
    public string SAgentRoleId { get; set; } = null!;

    public string? SAgentRoleName { get; set; }

    public string SAgentRoleGroupId { get; set; } = null!;

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
