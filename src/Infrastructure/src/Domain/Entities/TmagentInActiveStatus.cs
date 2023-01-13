using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentInActiveStatus
{
    public int NId { get; set; }

    public string SName { get; set; } = null!;

    public bool BActive { get; set; }

    public DateTime DCreateDate { get; set; }

    public string SCreateBy { get; set; } = null!;

    public DateTime DUpdateDate { get; set; }

    public string SUpdateBy { get; set; } = null!;

    public bool? SDisableUser { get; set; }
}
