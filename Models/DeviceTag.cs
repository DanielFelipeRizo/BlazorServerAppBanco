using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class DeviceTag
{
    public int DeviceTagId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public string? Name { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
