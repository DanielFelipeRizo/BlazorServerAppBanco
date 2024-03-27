using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Representative
{
    public long RepresentativeId { get; set; }

    public string? Name { get; set; }

    public int? IdentificationType { get; set; }

    public string? IdentificationNumber { get; set; }

    public string? Nit { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? VirtualCardNumber { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Commerce> Commerces { get; set; } = new List<Commerce>();

    public virtual RepresentativeIdentificationType? IdentificationTypeNavigation { get; set; }
}
