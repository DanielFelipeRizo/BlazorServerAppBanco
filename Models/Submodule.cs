using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Submodule
{
    public int SubmoduleId { get; set; }

    public int? ModuleId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Module? Module { get; set; }

    public virtual ICollection<ObfuscationField> ObfuscationFields { get; set; } = new List<ObfuscationField>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
