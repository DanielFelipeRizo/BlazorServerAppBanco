using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class ObfuscationRuleType
{
    public int ObfuscationRuleTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ObfuscationField> ObfuscationFields { get; set; } = new List<ObfuscationField>();

    public virtual ICollection<ObfuscationRule> ObfuscationRules { get; set; } = new List<ObfuscationRule>();
}
