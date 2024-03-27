using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class CapksRid
{
    public string KeyRid { get; set; } = null!;

    public string? Provider { get; set; }

    public virtual ICollection<Capk> Capks { get; set; } = new List<Capk>();
}
