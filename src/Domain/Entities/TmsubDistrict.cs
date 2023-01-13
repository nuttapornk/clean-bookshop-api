using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmsubDistrict
{
    public int NSubDistrictKey { get; set; }

    public int NDistrictKey { get; set; }

    public string? SSubDistrictCode { get; set; }

    public string? SSubDistrictNameTh { get; set; }

    public string? SSubDistrictNameEn { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SModifyBy { get; set; }

    public DateTime? DModifyDate { get; set; }
}
