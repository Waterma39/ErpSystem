using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Vacation
{
    public int Id { get; set; }

    public int VacYear { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? CodeNo { get; set; }

    public string? Remark { get; set; }
}
