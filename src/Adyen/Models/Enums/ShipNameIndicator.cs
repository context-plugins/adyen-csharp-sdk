using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.
/// Allowed values:
/// * <b>01</b> — Account Name identical to shipping Name
/// * <b>02</b> — Account Name different to shipping Name, Indicates whether the 3DS Requestor has experienced suspicious activity (including previous fraud) on the cardholder account.
/// Allowed values:
/// * <b>01</b> — No suspicious activity has been observed
/// * <b>02</b> — Suspicious activity has been observed
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShipNameIndicator>))]
public sealed record ShipNameIndicator : OpenStringEnum<ShipNameIndicator>
{
    private ShipNameIndicator(string value) : base(value)
    {
    }

    public static readonly ShipNameIndicator _01 = new("01");

    public static readonly ShipNameIndicator _02 = new("02");

    public TResult Match<TResult>(Func<TResult> on_01, Func<TResult> on_02, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _01 => on_01(),
            _ when this == _02 => on_02(),
            _ => otherwise(Value)
        };

    public void Match(Action on_01, Action on_02, Action<string> otherwise)
    {
        if (this == _01) on_01();
        else if (this == _02) on_02();
        else otherwise(Value);
    }
}
