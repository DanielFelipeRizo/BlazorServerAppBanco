using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class StatusType
{
    public long StatusTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<LicenseForCustomer> LicenseForCustomers { get; set; } = new List<LicenseForCustomer>();
}
