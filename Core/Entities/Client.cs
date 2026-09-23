using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Client
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? SortNo { get; set; }

    public string? ClientName { get; set; }

    public string? ImageUrl { get; set; }

    public string? WebsiteUrl { get; set; }

    public string? Remark { get; set; }
}
