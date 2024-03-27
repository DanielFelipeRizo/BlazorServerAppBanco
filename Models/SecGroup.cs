using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecGroup
{
    public int GroupId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ObfuscationField> ObfuscationFields { get; set; } = new List<ObfuscationField>();

    public virtual ICollection<SecGroupsApp> SecGroupsApps { get; set; } = new List<SecGroupsApp>();

    public virtual ICollection<SecUser> Logins { get; set; } = new List<SecUser>();
}
