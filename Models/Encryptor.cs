using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class Encryptor
{
    public int EncryptorId { get; set; }

    public byte[]? EncryptorPrivate { get; set; }

    public byte[]? EncryptorPublic { get; set; }

    public DateTime? EncryptorDate { get; set; }
}
