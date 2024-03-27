using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public string TemplateId { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? PrintVoucher { get; set; }

    public string? MaximumAmount { get; set; }

    public string? MaximumDollarAmount { get; set; }

    public string? MinimumAmount { get; set; }

    public string? MinimumAmountDollars { get; set; }

    public string? TransactionType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? DailyTransactions { get; set; }

    public virtual TemplateTransaction Template { get; set; } = null!;
}
