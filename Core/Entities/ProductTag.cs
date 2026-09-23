using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ProductTag
{
    public int Id { get; set; }

    public string? ProdNo { get; set; }

    public string? TagName { get; set; }

    public string? Remark { get; set; }
}
