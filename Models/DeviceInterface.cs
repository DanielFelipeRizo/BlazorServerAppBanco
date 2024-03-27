﻿using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class DeviceInterface
{
    public int DeviceInterfaceId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
