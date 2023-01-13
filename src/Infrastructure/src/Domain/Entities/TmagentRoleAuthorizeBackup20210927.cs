using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentRoleAuthorizeBackup20210927
{
    public int NRoleAuthorizeId { get; set; }

    public string SAgentRoleId { get; set; } = null!;

    public int NMenuId { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
