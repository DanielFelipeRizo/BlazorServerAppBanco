using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class LicenseForCustomer
{
    public long LicenseForCustomerId { get; set; }

    public DateTime CreationDate { get; set; }

    public long StatusTypeId { get; set; }

    public long CustomerId { get; set; }

    public long LicenseTypeId { get; set; }

    public string Key { get; set; } = null!;

    public virtual LicenseType LicenseType { get; set; } = null!;

    public virtual StatusType StatusType { get; set; } = null!;
}
