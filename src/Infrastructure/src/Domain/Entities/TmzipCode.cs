using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmzipCode
{
    public int NZipCodeKey { get; set; }

    public string SZipCode { get; set; } = null!;

    public int NDistrictKey { get; set; }

    public string? SPostOffice { get; set; }

    public string? SRemark { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SModifyBy { get; set; }

    public DateTime? DModifyDate { get; set; }
}
