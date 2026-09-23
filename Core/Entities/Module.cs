using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Module
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsWorkflow { get; set; }

    public string? RoleNo { get; set; }

    public string? SortNo { get; set; }

    public string? ModuleNo { get; set; }

    public string? ModuleName { get; set; }

    public string? IconName { get; set; }

    public string? Remark { get; set; }
}
