using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Featured
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? SortNo { get; set; }

    public string? ProdNo { get; set; }

    public string? Remark { get; set; }
}
