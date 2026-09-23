using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class EmployeeAgent
{
    public int Id { get; set; }

    public bool IsEnabled { get; set; }

    public string? EmpNo { get; set; }

    public string? AgentNo { get; set; }

    public string? Remark { get; set; }
}
