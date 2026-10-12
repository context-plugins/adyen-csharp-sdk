using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the identification.
/// <para>
/// Possible values: <b>iban</b>, <b>routingNumber</b>, <b>sortCode</b>, <b>bic</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationType>))]
public sealed record IdentificationType : OpenStringEnum<IdentificationType>
{
    private IdentificationType(string value) : base(value)
    {
    }

    public static readonly IdentificationType Bic = new("bic");

    public static readonly IdentificationType Iban = new("iban");

    public static readonly IdentificationType RoutingNumber = new("routingNumber");

    public static readonly IdentificationType SortCode = new("sortCode");

    public TResult Match<TResult>(Func<TResult> onBic,
        Func<TResult> onIban,
        Func<TResult> onRoutingNumber,
        Func<TResult> onSortCode,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bic => onBic(),
            _ when this == Iban => onIban(),
            _ when this == RoutingNumber => onRoutingNumber(),
            _ when this == SortCode => onSortCode(),
            _ => otherwise(Value)
        };

    public void Match(Action onBic, Action onIban, Action onRoutingNumber, Action onSortCode, Action<string> otherwise)
    {
        if (this == Bic) onBic();
        else if (this == Iban) onIban();
        else if (this == RoutingNumber) onRoutingNumber();
        else if (this == SortCode) onSortCode();
        else otherwise(Value);
    }
}
