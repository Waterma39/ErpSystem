using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class WorkflowRole
{
    public int Id { get; set; }

    public string? RoleNo { get; set; }

    public string? RoleName { get; set; }

    public string? Remark { get; set; }
}
