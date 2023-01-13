using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmagentRoleAuthorizeStatus
{
    public int NRoleAuthorizeStatusId { get; set; }

    public string SAgentRoleId { get; set; } = null!;

    public int NMenuId { get; set; }

    public int NRequestStatusId { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmmenu NMenu { get; set; } = null!;

    public virtual TmagentRole SAgentRole { get; set; } = null!;
}
