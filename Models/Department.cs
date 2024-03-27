using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? Name { get; set; }

    public string? CountryCode { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country? CountryCodeNavigation { get; set; }
}
