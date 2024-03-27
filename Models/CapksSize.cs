using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class CapksSize
{
    public string KeySize { get; set; } = null!;

    public virtual ICollection<Capk> Capks { get; set; } = new List<Capk>();
}
