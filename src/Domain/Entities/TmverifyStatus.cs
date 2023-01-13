using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmverifyStatus
{
    public string SVerifyStatusId { get; set; } = null!;

    public string? SVerifyStatusNameTh { get; set; }

    public string? SVerifyStatusNameEn { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TthverifyRegister> TthverifyRegisters { get; } = new List<TthverifyRegister>();

    public virtual ICollection<TtverifyProfileAgent> TtverifyProfileAgents { get; } = new List<TtverifyProfileAgent>();
}
