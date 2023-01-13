using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmreasonApprove
{
    public long NReasonApproveId { get; set; }

    public string SReasonApproveNameTh { get; set; } = null!;

    public string? SReasonApproveNameEn { get; set; }

    public bool? BEnable { get; set; }

    public int? NOrder { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TtdverifyRegisterDetail> TtdverifyRegisterDetails { get; } = new List<TtdverifyRegisterDetail>();
}
