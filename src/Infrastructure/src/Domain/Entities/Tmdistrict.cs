using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class Tmdistrict
{
    public int NDistrictKey { get; set; }

    public int NProvinceKey { get; set; }

    public string? SDistrictNameTh { get; set; }

    public string? SDistrictNameEn { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SModifyBy { get; set; }

    public DateTime? DModifyDate { get; set; }
}
