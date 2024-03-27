using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class SecEmail
{
    public int SecEmailId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public bool? AuthenticationFlag { get; set; }

    public string? PlainValue { get; set; }

    public string? Smtp { get; set; }

    public string? Port { get; set; }
}
