using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class Tmbank
{
    public short NBankId { get; set; }

    public string? SBankName { get; set; }

    public string? SBankShortName { get; set; }

    public string? SBankCode { get; set; }

    public byte[]? IBankImage { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TmagentBankAccount> TmagentBankAccounts { get; } = new List<TmagentBankAccount>();
}
