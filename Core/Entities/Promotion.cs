using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Promotion
{
    public int Id { get; set; }

    public string? SortNo { get; set; }

    public string? ProdNo { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int SalePrice { get; set; }

    public string? Remark { get; set; }
}
