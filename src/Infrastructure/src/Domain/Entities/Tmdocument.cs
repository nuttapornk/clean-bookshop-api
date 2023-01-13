using System;
using System.Collections.Generic;

namespace Infrastructure.src.Domain.Entities;

public partial class Tmdocument
{
    public string SDocumentId { get; set; } = null!;

    public string? SDocumentName { get; set; }

    public int? NMaxSize { get; set; }

    public string? SExtension { get; set; }

    public int? NOrder { get; set; }

    public bool? BEnable { get; set; }

    public string? SCreateBy { get; set; }

    public DateTime? DCreateDate { get; set; }

    public string? SUpdateBy { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<TmagentDocument> TmagentDocuments { get; } = new List<TmagentDocument>();
}
