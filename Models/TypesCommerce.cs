using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TypesCommerce
{
    public int TypeCommerceId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Status { get; set; }

    public string? Name { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Commerce> Commerces { get; set; } = new List<Commerce>();
}
