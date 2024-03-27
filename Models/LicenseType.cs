using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class LicenseType
{
    public long LicenseTypeId { get; set; }

    public string? Description { get; set; }

    public int? DaysNumbers { get; set; }

    public virtual ICollection<LicenseForCustomer> LicenseForCustomers { get; set; } = new List<LicenseForCustomer>();
}
