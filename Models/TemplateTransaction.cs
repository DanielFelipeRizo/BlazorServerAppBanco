using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TemplateTransaction
{
    public string TemplateId { get; set; } = null!;

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
