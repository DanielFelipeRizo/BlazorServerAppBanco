using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class TemplateBranchesHour
{
    public string TemplateId { get; set; } = null!;

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<BranchesTransactionsHour> BranchesTransactionsHours { get; set; } = new List<BranchesTransactionsHour>();
}
