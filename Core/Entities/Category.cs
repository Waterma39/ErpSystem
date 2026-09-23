using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Category
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsCategory { get; set; }

    public string? ParentNo { get; set; }

    public string? CategoryNo { get; set; }

    public string? SortNo { get; set; }

    public string? CategoryName { get; set; }

    public string? RouteName { get; set; }

    public string? Remark { get; set; }
}
