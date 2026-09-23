using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Payment
{
    public int Id { get; set; }

    public string? PaymentNo { get; set; }

    public string? PaymentName { get; set; }

    public string? Remark { get; set; }
}
