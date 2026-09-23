using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Department
{
    public int Id { get; set; }

    public string? DeptNo { get; set; }

    public string? DeptName { get; set; }

    public string? Remark { get; set; }
}
