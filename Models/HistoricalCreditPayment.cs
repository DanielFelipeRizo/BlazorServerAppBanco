using System;
using System.Collections.Generic;

namespace BlazorServerAppBanco.Models;

public partial class HistoricalCreditPayment
{
    public int CreditPaymentId { get; set; }

    public string? Device { get; set; }

    public string? TraceNumber { get; set; }

    public string? CorrespondentId { get; set; }

    public string? CreditOperationIdentifier { get; set; }

    public string? Amount { get; set; }

    public string? AmountCurrency { get; set; }

    public string? DebitAccountIdentifier { get; set; }

    public string? TransactionName { get; set; }

    public string? DeviceIp { get; set; }

    public string? Channel { get; set; }

    public string? VoucherId { get; set; }

    public string? OperationCurrency { get; set; }

    public string? AnnualPercentageRateCost { get; set; }

    public string? Capital { get; set; }

    public string? Interest { get; set; }

    public string? ExchangeRate { get; set; }

    public string? PenaltyInterest { get; set; }

    public string? InsuranceDes { get; set; }

    public string? FinancialTransactionTax { get; set; }

    public string? JudicialExpenses { get; set; }

    public string? DeferredAmount { get; set; }

    public string? DeferredInterest { get; set; }

    public string? CommerceId { get; set; }

    public string? BranchId { get; set; }

    public string? DeviceId { get; set; }

    public string? CommerceName { get; set; }

    public string? BranchAddress { get; set; }

    public string? RepresentativeName { get; set; }

    public string? RepresentativeDocument { get; set; }

    public string? Phone { get; set; }

    public string? Nit { get; set; }

    public string? TransactionType { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public string? Status { get; set; }

    public string? DateTransaction { get; set; }

    public string? TimeTransaction { get; set; }

    public string? PaymentMethod { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? PaymentIdentifier { get; set; }

    public string? AsfiCommerce { get; set; }

    public string? Regional { get; set; }

    public string? TransactionCardNumber { get; set; }
}
