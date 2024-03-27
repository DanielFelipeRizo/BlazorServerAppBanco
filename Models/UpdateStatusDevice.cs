using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class UpdateStatusDevice
{
    public int UpdateStatusDeviceId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
