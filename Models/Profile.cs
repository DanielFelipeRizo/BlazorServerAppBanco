using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string Description { get; set; } = null!;

    public string? TemplateRanges { get; set; }

    public string? TemplateCapks { get; set; }

    public string? TemplateEmvapps { get; set; }

    public string? TemplateTransactions { get; set; }

    public virtual ICollection<Commerce> Commerces { get; set; } = new List<Commerce>();

    public virtual TemplateCapk? TemplateCapksNavigation { get; set; }

    public virtual TemplateEmvapp? TemplateEmvappsNavigation { get; set; }

    public virtual TemplateRange? TemplateRangesNavigation { get; set; }

    public virtual TemplateTransaction? TemplateTransactionsNavigation { get; set; }
}
