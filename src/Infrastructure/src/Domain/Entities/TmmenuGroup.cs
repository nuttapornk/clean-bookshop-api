using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmmenuGroup
{
    public string SMenuGroupId { get; set; } = null!;

    public string? SMenuGroupName { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
