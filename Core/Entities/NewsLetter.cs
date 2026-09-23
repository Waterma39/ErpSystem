using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class NewsLetter
{
    public int Id { get; set; }

    public string? UserEmail { get; set; }

    public DateTime? SubscribeDate { get; set; }

    public string? Remark { get; set; }
}
