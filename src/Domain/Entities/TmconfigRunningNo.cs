using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TmconfigRunningNo
{
    public string SRunningType { get; set; } = null!;

    public string? SRunningTypeDescription { get; set; }

    public string? SPreFix { get; set; }

    /// <summary>
    /// จำนวนหลักทั้งหมด
    /// </summary>
    public int NDigitAutoRunning { get; set; }
}
