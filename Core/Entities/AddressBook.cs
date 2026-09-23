using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class AddressBook
{
    public int Id { get; set; }

    public string? UserNo { get; set; }

    public string? CodeNo { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EngName { get; set; }

    public string? GenderCode { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? CompName { get; set; }

    public string? CompId { get; set; }

    public string? DeptName { get; set; }

    public string? TitleName { get; set; }

    public string? CompTel { get; set; }

    public string? ContactTel { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactAddress { get; set; }

    public string? LineId { get; set; }

    public string? FacebookId { get; set; }

    public string? TwitterId { get; set; }

    public string? InstagramId { get; set; }

    public string? LinkedInId { get; set; }

    public string? Remark { get; set; }
}
