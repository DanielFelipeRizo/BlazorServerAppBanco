using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class StatusType
{
    public long StatusTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();

    public virtual ICollection<LicenseForCustomer> LicenseForCustomers { get; set; } = new List<LicenseForCustomer>();
}
