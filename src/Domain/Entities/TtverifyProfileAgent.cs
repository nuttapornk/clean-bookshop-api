using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TtverifyProfileAgent
{
    public string SVerifyProfileAgentId { get; set; } = null!;

    public string SAgentId { get; set; } = null!;

    public string SVerifyStatusId { get; set; } = null!;

    public string SAgentProfileTypeId { get; set; } = null!;

    public long SRefId { get; set; }

    public long? SRefDocumentId { get; set; }

    public string? SVerifyBy { get; set; }

    public DateTime? DVerifyDate { get; set; }

    public string? Remark { get; set; }

    public string? SCredateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;

    public virtual TmagentProfileType SAgentProfileType { get; set; } = null!;

    public virtual TmverifyStatus SVerifyStatus { get; set; } = null!;
}
