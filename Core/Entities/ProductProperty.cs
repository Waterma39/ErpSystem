using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ProductProperty
{
    public int Id { get; set; }

    public bool IsSelect { get; set; }

    public string? ProdNo { get; set; }

    public string? PropertyNo { get; set; }

    public string? PropertyValue { get; set; }

    public string? Remark { get; set; }
}
