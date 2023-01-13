using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TthverifyRegister
{
    public string SVerifyRegisterId { get; set; } = null!;

    public string SAgentId { get; set; } = null!;

    public string SVerifyStatusId { get; set; } = null!;

    public string? SRemark { get; set; }

    public DateTime? DVerifyDate { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;

    public virtual TmverifyStatus SVerifyStatus { get; set; } = null!;

    public virtual ICollection<TtdverifyRegisterDetail> TtdverifyRegisterDetails { get; } = new List<TtdverifyRegisterDetail>();
}
