using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class TmagentDocument
{
    public long NAgentDocumentId { get; set; }

    public string SAgentId { get; set; } = null!;

    public string SDocumentId { get; set; } = null!;

    public string? SAgentDocumentName { get; set; }

    public string? SAgentDocumentDescription { get; set; }

    public byte[]? IAgentDocunmentContent { get; set; }

    public int? NFileSize { get; set; }

    public bool? BIsActive { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Tmagent SAgent { get; set; } = null!;

    public virtual Tmdocument SDocument { get; set; } = null!;
}
