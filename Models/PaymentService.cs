using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class PaymentService
{
    public long PaymentServicesId { get; set; }

    public string? Device { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionName { get; set; }

    public string? Status { get; set; }

    public string? PaymentMethod { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? Channel { get; set; }

    public string? DateTransaction { get; set; }

    public string? DebitAmount { get; set; }

    public string? DebitCoin { get; set; }

    public string? DebitCurrency { get; set; }

    public string? ExchangeRate { get; set; }

    public string? ExchangeRateCurrency { get; set; }

    public string? NameAccount { get; set; }

    public string? Period { get; set; }

    public string? Sequential { get; set; }

    public string? ServiceAccount { get; set; }

    public string? ServiceDetail { get; set; }

    public string? ServiceName { get; set; }

    public string? TimeTransaction { get; set; }

    public string? TotalAmount { get; set; }

    public string? TotalAmountCurrency { get; set; }

    public string? CommerceId { get; set; }

    public string? BranchId { get; set; }

    public string? DeviceId { get; set; }

    public string? CommerceName { get; set; }

    public string? BranchAddress { get; set; }

    public string? RepresentativeName { get; set; }

    public string? RepresentativeDocument { get; set; }

    public string? Phone { get; set; }

    public string? Nit { get; set; }

    public string? CreateBy { get; set; }

    public string? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public string? CustomerId { get; set; }

    public string? PaymentIdentifier { get; set; }

    public string? AsfiCommerce { get; set; }

    public string? Regional { get; set; }

    public string? TransactionCardNumber { get; set; }

    public string? CorrespondentId { get; set; }

    public string? TraceNumber { get; set; }
}
