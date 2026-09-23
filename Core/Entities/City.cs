using System;
using System.Collections.Generic;

namespace ErpSystem.Core.Entities;

public partial class City
{
    public int Id { get; set; }

    public string? SortNo { get; set; }

    public string? CityName { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Remark { get; set; }
}
