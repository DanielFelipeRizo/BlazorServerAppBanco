using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Table
{
    public int TableId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? ModuleId { get; set; }

    public int? SubmoduleId { get; set; }

    public virtual Module? Module { get; set; }

    public virtual ICollection<ObfuscationField> ObfuscationFields { get; set; } = new List<ObfuscationField>();

    public virtual Submodule? Submodule { get; set; }
}
