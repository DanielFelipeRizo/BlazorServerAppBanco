using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class BranchesTransactionsHour
{
    public int BranchTransactionHoursId { get; set; }

    public string TemplateId { get; set; } = null!;

    public TimeOnly? StartTimeTransaction { get; set; }

    public TimeOnly? EndTimeTransaction { get; set; }

    public string BusinessDays { get; set; } = null!;

    public string? DaysMondaySunday { get; set; }

    public virtual DayTransaction BusinessDaysNavigation { get; set; } = null!;

    public virtual TemplateBranchesHour Template { get; set; } = null!;
}
