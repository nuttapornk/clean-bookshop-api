using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Tmmenu
{
    public int NMenuId { get; set; }

    public string? SMenuCode { get; set; }

    public string? SMenuUrl { get; set; }

    public string? SMenuDescTh { get; set; }

    public string? SMenuDescEn { get; set; }

    public int? NMenuParentId { get; set; }

    public string? SMenuGroupId { get; set; }

    public int? NMenuOrder { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TmagentRoleAuthorizeStatus> TmagentRoleAuthorizeStatuses { get; } = new List<TmagentRoleAuthorizeStatus>();

    public virtual ICollection<TmagentRoleAuthorize> TmagentRoleAuthorizes { get; } = new List<TmagentRoleAuthorize>();
}
