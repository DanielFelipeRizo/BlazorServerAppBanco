using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class EmvappsDetail
{
    public string TemplateId { get; set; } = null!;

    public string Aid { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public string Value { get; set; } = null!;

    public virtual EmvappsAid AidNavigation { get; set; } = null!;

    public virtual EmvappsMaster EmvappsMaster { get; set; } = null!;

    public virtual EmvappsTag TagNavigation { get; set; } = null!;

    public virtual TemplateEmvapp Template { get; set; } = null!;
}
