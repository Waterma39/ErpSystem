using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Role
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? RoleNo { get; set; }

    public string? RoleName { get; set; }

    public string? Remark { get; set; }
}
