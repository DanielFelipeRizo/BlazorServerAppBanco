using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecApp
{
    public string AppName { get; set; } = null!;

    public string? AppType { get; set; }

    public string? Description { get; set; }
}
