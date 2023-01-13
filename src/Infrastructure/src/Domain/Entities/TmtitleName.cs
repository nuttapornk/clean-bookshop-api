using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmtitleName
{
    public int NTitleKey { get; set; }

    public string SCustomerType { get; set; } = null!;

    public string STitleDescription { get; set; } = null!;

    public string SFullTitleDescription { get; set; } = null!;

    public string SGender { get; set; } = null!;

    public string SGenderThai { get; set; } = null!;

    public string SEnglishTitle { get; set; } = null!;

    public string SAfsMappingCode { get; set; } = null!;

    public int NTitleOrder { get; set; }

    public bool BIsActive { get; set; }

    public DateTime DUpdateDate { get; set; }
}
