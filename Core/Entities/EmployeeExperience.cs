using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class EmployeeExperience
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? CompName { get; set; }

    public string? DeptName { get; set; }

    public string? TitleName { get; set; }

    public string? BossName { get; set; }

    public int? Salary { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? QuitReason { get; set; }

    public string? Remark { get; set; }
}
