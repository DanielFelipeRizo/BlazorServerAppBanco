using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class ObfuscationRule
{
    public int ObfuscationRuleId { get; set; }

    public int ObfuscationRuleTypeId { get; set; }

    public string Name { get; set; } = null!;

    public int? VisibleCharactersStart { get; set; }

    public int? VisibleCharactersEnd { get; set; }

    public int? ObfuscatedCharactersStart { get; set; }

    public int? ObfuscatedCharactersEnd { get; set; }

    public int? VisibleWordsStart { get; set; }

    public int? VisibleWordsEnd { get; set; }

    public bool? ObfuscationPerWord { get; set; }

    public bool? ObfuscateAll { get; set; }

    public bool? State { get; set; }

    public virtual ObfuscationRuleType ObfuscationRuleType { get; set; } = null!;
}
