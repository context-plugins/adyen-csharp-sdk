using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The service for which you are creating the business line.
/// <para>
///
/// </para>
/// <para>
/// Possible values:
/// *  <b>paymentProcessing</b>
/// *  <b>issuing</b>
/// *  <b>banking</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Service>))]
public sealed record Service : OpenStringEnum<Service>
{
    private Service(string value) : base(value)
    {
    }

    public static readonly Service PaymentProcessing = new("paymentProcessing");

    public static readonly Service Issuing = new("issuing");

    public static readonly Service Banking = new("banking");

    public TResult Match<TResult>(Func<TResult> onPaymentProcessing,
        Func<TResult> onIssuing,
        Func<TResult> onBanking,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PaymentProcessing => onPaymentProcessing(),
            _ when this == Issuing => onIssuing(),
            _ when this == Banking => onBanking(),
            _ => otherwise(Value)
        };

    public void Match(Action onPaymentProcessing, Action onIssuing, Action onBanking, Action<string> otherwise)
    {
        if (this == PaymentProcessing) onPaymentProcessing();
        else if (this == Issuing) onIssuing();
        else if (this == Banking) onBanking();
        else otherwise(Value);
    }
}
