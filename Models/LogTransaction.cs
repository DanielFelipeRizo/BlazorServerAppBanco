using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class LogTransaction
{
    public string? Pk { get; set; }

    public string? OriginalValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Usr { get; set; }

    public string? Application { get; set; }

    public string? ColumnName { get; set; }
}
