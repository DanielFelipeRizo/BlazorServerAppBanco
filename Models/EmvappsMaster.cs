using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class EmvappsMaster
{
    public string TemplateId { get; set; } = null!;

    public string Aid { get; set; } = null!;

    public virtual EmvappsAid AidNavigation { get; set; } = null!;

    public virtual ICollection<EmvappsDetail> EmvappsDetails { get; set; } = new List<EmvappsDetail>();

    public virtual TemplateEmvapp Template { get; set; } = null!;
}
