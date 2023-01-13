using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentBankAccount
{
    public long NAgentBankAccountId { get; set; }

    public string SAgentId { get; set; } = null!;

    public short NBankId { get; set; }

    public string? SAccountName { get; set; }

    public string? SAccountNumber { get; set; }

    public bool? BIsActive { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmbank NBank { get; set; } = null!;

    public virtual Tmagent SAgent { get; set; } = null!;
}
