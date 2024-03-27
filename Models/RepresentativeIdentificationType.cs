using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class RepresentativeIdentificationType
{
    public int RepresentativeIdentificationTypeId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Representative> Representatives { get; set; } = new List<Representative>();
}
