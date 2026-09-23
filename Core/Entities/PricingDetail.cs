using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class PricingDetail
{
    public int Id { get; set; }

    public string? PricingNo { get; set; }

    public bool IsSupport { get; set; }

    public string? SortNo { get; set; }

    public string? ItemName { get; set; }

    public string? Remark { get; set; }
}
