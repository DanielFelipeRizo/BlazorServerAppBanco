using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class City
{
    public int CityId { get; set; }

    public int Code { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
