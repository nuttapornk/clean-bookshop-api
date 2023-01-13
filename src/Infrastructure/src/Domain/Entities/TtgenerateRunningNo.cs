using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TtgenerateRunningNo
{
    public string SRunningType { get; set; } = null!;

    public int NCurrentRunningNo { get; set; }
}
