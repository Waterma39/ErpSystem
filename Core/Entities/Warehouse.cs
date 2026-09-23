using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Warehouse
{
    public int Id { get; set; }

    public string? WarehouseNo { get; set; }

    public string? WarehouseName { get; set; }

    public string? Remark { get; set; }
}
