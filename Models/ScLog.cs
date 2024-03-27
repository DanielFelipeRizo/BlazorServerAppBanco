using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class ScLog
{
    public int Id { get; set; }

    public DateTime? InsertedDate { get; set; }

    public string Username { get; set; } = null!;

    public string Application { get; set; } = null!;

    public string Creator { get; set; } = null!;

    public string IpUser { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string? Description { get; set; }
}
