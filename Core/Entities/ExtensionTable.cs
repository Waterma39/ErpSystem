using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ExtensionTable
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string? SortNo { get; set; }

    public string? ExtName { get; set; }

    public string? ExtNo { get; set; }

    public string? Remark { get; set; }
}
