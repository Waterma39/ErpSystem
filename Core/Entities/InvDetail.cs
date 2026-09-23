using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class InvDetail
{
    public int Id { get; set; }

    public string? WareHouseNo { get; set; }

    public string? ProductNo { get; set; }

    public int Qty { get; set; }

    public string? Remark { get; set; }
}
