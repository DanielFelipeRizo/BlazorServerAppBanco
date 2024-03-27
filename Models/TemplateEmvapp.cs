using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TemplateEmvapp
{
    public string TemplateId { get; set; } = null!;

    public virtual ICollection<EmvappsDetail> EmvappsDetails { get; set; } = new List<EmvappsDetail>();

    public virtual ICollection<EmvappsMaster> EmvappsMasters { get; set; } = new List<EmvappsMaster>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
