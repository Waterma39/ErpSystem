using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Shipping
{
    public int Id { get; set; }

    public string? ShippingNo { get; set; }

    public string? ShippingName { get; set; }

    public string? Remark { get; set; }
}
