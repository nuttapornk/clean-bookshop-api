using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmmenuBackup20210927
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
}
