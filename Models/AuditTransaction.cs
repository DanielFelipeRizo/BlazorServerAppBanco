using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class AuditTransaction
{
    public long Id { get; set; }

    public string? ProcessCode { get; set; }

    public string? Process { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

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

    public string? ApiJsonRequest { get; set; }

    public string? ApiJsonResponse { get; set; }

    public DateTime? ApiStartDate { get; set; }

    public DateTime? ApiEndDate { get; set; }

    public string? ApiTotalTime { get; set; }

    public string? ApiToken { get; set; }

    public string? ApiErrorDescription { get; set; }

    public string? ApiErrorCode { get; set; }

    public string? ApiTraceNumber { get; set; }

    public string? ApiCorrespondentId { get; set; }

    public string? ApiIdCard { get; set; }

    public string? ApiWpossTransactionId { get; set; }

    public string? ApiCustomerCode { get; set; }

    public string? ApiDocument { get; set; }

    public string? ApiTransactionType { get; set; }

    public string? ApiAccountId { get; set; }

    public string? ApiReceiptId { get; set; }

    public string? ApiFinancialAccountNumber { get; set; }

    public string? ApiUser { get; set; }

    public string? ApiCityId { get; set; }

    public string? ApiServiceTypeId { get; set; }

    public string? ApiCompanyId { get; set; }

    public string? ApiSearchTypeId { get; set; }

    public string? ApiServiceAccount { get; set; }

    public string? ApiInvoiceName { get; set; }

    public string? ApiTransactionId { get; set; }

    public string? Uuid { get; set; }
}
