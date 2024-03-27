using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class DeviceBrand
{
    public int DeviceBrandId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
