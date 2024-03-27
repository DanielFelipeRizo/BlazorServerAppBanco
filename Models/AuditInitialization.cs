using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class AuditInitialization
{
    public long Id { get; set; }

    public string? ProcessCode { get; set; }

    public string? Process { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? ResponseTime { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseMessage { get; set; }

    public string? Node { get; set; }

    public string? PosIp { get; set; }

    public string? PosPort { get; set; }

    public string? HostIp { get; set; }

    public string? HostPort { get; set; }

    public byte[]? PosMessage { get; set; }

    public byte[]? HostMessage { get; set; }
}
