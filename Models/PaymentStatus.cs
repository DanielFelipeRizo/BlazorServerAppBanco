using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class PaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string? Description { get; set; }
}
