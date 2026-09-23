using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ProductFeatured
{
    public int Id { get; set; }

    public string? ProdNo { get; set; }

    public string? SortNo { get; set; }

    public string? FeaturedName { get; set; }

    public string? Remark { get; set; }
}
