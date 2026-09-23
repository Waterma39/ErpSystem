using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class EmployeeSchool
{
    public int Id { get; set; }

    public string? EmpNo { get; set; }

    public string? EducationNo { get; set; }

    public string? SchoolName { get; set; }

    public string? SubjectName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsGraduate { get; set; }

    public string? Remark { get; set; }
}
