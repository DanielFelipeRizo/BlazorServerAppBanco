using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class LogsFunction
{
    public int LogId { get; set; }

    public string Login { get; set; } = null!;

    public string LogNameObject { get; set; } = null!;

    public string? LogParametersInput { get; set; }

    public string? LogParametersOutput { get; set; }

    public string? LogCodeErrorDatabase { get; set; }

    public string? LogMessageErrorDatabase { get; set; }

    public string? LogCodeErrorChecked { get; set; }

    public string? LogMessageErrorChecked { get; set; }

    public int? LogResponseTimeMilliseconds { get; set; }

    public DateTime? LogDateInput { get; set; }

    public DateTime? LogDateOutput { get; set; }
}
