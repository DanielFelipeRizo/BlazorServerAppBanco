using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Range
{
    public string TemplateId { get; set; } = null!;

    public int RangeId { get; set; }

    public string? CntDigitsLowerLimit { get; set; }

    public string? CntDigitsUpperLimit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? LowerLimit { get; set; }

    public string? UpperLimit { get; set; }

    public string? CardType { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TemplateRange Template { get; set; } = null!;
}
