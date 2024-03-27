using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class EmvappsAid
{
    public string Aid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<EmvappsDetail> EmvappsDetails { get; set; } = new List<EmvappsDetail>();

    public virtual ICollection<EmvappsMaster> EmvappsMasters { get; set; } = new List<EmvappsMaster>();
}
