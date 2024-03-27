using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Country
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Continent { get; set; } = null!;

    public string Region { get; set; } = null!;

    public double Area { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
