using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Module
{
    public int ModuleId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ObfuscationField> ObfuscationFields { get; set; } = new List<ObfuscationField>();

    public virtual ICollection<Submodule> Submodules { get; set; } = new List<Submodule>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
