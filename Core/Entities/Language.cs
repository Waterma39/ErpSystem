using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class Language
{
    public int Id { get; set; }

    public string? LangNo { get; set; }

    public string? LangName { get; set; }

    public string? Remark { get; set; }
}
