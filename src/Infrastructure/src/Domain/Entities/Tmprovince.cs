using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class Tmprovince
{
    public int NProvinceKey { get; set; }

    public string? SProvinceNameTh { get; set; }

    public string? SProvinceNameEn { get; set; }

    public string? NGeoId { get; set; }

    public string? SProvinceShort { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SModifyBy { get; set; }

    public DateTime? DModifyDate { get; set; }
}
