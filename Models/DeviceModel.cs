using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class DeviceModel
{
    public int DeviceModelId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
