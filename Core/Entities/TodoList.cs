using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class TodoList
{
    public int Id { get; set; }

    public bool IsFinished { get; set; }

    public string? UserNo { get; set; }

    public string? CodeNo { get; set; }

    public string? TitleName { get; set; }

    public DateTime DeadlineDate { get; set; }

    public string? Remark { get; set; }
}
