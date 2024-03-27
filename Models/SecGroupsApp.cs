using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecGroupsApp
{
    public int GroupId { get; set; }

    public string AppName { get; set; } = null!;

    public string? PrivAccess { get; set; }

    public string? PrivInsert { get; set; }

    public string? PrivDelete { get; set; }

    public string? PrivUpdate { get; set; }

    public string? PrivExport { get; set; }

    public string? PrivPrint { get; set; }

    public string? Module { get; set; }

    public string? Submodule { get; set; }

    public virtual SecGroup Group { get; set; } = null!;
}
