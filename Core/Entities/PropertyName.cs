using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class PropertyName
{
    public int Id { get; set; }

    public string? PropName { get; set; }

    public string? DisplayName { get; set; }

    public string? Remark { get; set; }
}
