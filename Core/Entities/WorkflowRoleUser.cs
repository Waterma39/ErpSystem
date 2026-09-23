using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class WorkflowRoleUser
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? RoleNo { get; set; }

    public string? UserNo { get; set; }

    public string? AgentNo { get; set; }

    public string? Remark { get; set; }
}
