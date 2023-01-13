using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TtdverifyRegisterDetail
{
    public string SVerifyRegisterDetailId { get; set; } = null!;

    public string SVerifyRegisterId { get; set; } = null!;

    public long NReasonRejectId { get; set; }

    public long? NReasonApproveId { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? SUpdateDate { get; set; }

    public virtual TmreasonApprove? NReasonApprove { get; set; }

    public virtual TmreasonReject NReasonReject { get; set; } = null!;

    public virtual TthverifyRegister SVerifyRegister { get; set; } = null!;
}
