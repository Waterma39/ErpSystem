using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Title
{
    public int Id { get; set; }

    public string? TitleNo { get; set; }

    public string? TitleName { get; set; }

    public string? Remark { get; set; }
}
