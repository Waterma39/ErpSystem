using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class ViCodeVacation
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? BaseNo { get; set; }

    public string? ParentNo { get; set; }

    public string? SortNo { get; set; }

    public string? CodeNo { get; set; }

    public string? CodeName { get; set; }

    public string? CodeValue { get; set; }

    public string? Remark { get; set; }
}
