using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class ObfuscationField
{
    public int ObfuscationFieldId { get; set; }

    public string? ObfuscationFieldName { get; set; }

    public int RuleTypeId { get; set; }

    public int RuleId { get; set; }

    public int? TableId { get; set; }

    public int RoleGroupId { get; set; }

    public string? ColumnName { get; set; }

    public int? SubmoduleId { get; set; }

    public int? ModuleId { get; set; }

    public virtual Module? Module { get; set; }

    public virtual SecGroup RoleGroup { get; set; } = null!;

    public virtual ObfuscationRuleType RuleType { get; set; } = null!;

    public virtual Submodule? Submodule { get; set; }

    public virtual Table? Table { get; set; }
}
