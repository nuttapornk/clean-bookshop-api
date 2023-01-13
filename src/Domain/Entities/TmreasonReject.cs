using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmreasonReject
{
    public long NReasonRejectId { get; set; }

    public string SReasonRejectNameTh { get; set; } = null!;

    public string? SReasonRejectNameEn { get; set; }

    public bool? BEnable { get; set; }

    public int? NOrder { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TtdverifyRegisterDetail> TtdverifyRegisterDetails { get; } = new List<TtdverifyRegisterDetail>();
}
