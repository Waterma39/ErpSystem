using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class AboutU
{
    public int Id { get; set; }

    public string? HeaderName { get; set; }

    public string? TitleName { get; set; }

    public string? Description { get; set; }

    public string? DetailText { get; set; }

    public string? Remark { get; set; }
}
