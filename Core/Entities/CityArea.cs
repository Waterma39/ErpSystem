using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class CityArea
{
    public int Id { get; set; }

    public string? CityName { get; set; }

    public string? AreaName { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Remark { get; set; }
}
