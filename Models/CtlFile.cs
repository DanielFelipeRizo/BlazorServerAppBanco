using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class CtlFile
{
    public long CtlFilesId { get; set; }

    public DateTime Date { get; set; }

    public string FileName { get; set; } = null!;

    public byte[]? AppData { get; set; }

    public string? Hash { get; set; }
}
