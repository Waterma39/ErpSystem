using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ProductInventory
{
    public int Id { get; set; }

    public string? ProdNo { get; set; }

    public string? PropertyNo { get; set; }

    public bool IsInventory { get; set; }

    public int InventoryQty { get; set; }

    public string? Remark { get; set; }
}
