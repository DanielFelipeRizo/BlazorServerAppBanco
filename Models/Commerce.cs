using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Commerce
{
    public long CommerceId { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? TypeCommerce { get; set; }

    public DateOnly? CommerceStartDate { get; set; }

    public int? ProfileId { get; set; }

    public long? RepresentativeId { get; set; }

    public string? AsfiCommerce { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();

    public virtual Profile? Profile { get; set; }

    public virtual Representative? Representative { get; set; }

    public virtual TypesCommerce? TypeCommerceNavigation { get; set; }
}
