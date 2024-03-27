using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TemplateCapk
{
    public string TemplateId { get; set; } = null!;

    public virtual ICollection<Capk> Capks { get; set; } = new List<Capk>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
