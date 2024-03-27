using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TemplateRange
{
    public string TemplateId { get; set; } = null!;

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Range> Ranges { get; set; } = new List<Range>();
}
