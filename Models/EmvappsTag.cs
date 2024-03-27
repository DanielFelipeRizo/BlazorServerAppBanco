using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class EmvappsTag
{
    public string Tag { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<EmvappsDetail> EmvappsDetails { get; set; } = new List<EmvappsDetail>();
}
