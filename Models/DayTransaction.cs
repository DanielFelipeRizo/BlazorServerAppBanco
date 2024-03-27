using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class DayTransaction
{
    public string DayTransactionId { get; set; } = null!;

    public int OrderDays { get; set; }

    public virtual ICollection<BranchesTransactionsHour> BranchesTransactionsHours { get; set; } = new List<BranchesTransactionsHour>();
}
