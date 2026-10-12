using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of Loyalty processing requested by the Sale System. An way to specify what the POI has to handle concerning the loyalty.
/// Possible values:
/// * <b>Allowed</b>
/// * <b>Forbidden</b>
/// * <b>Processed</b>
/// * <b>Proposed</b>
/// * <b>Required</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyHandling2>))]
public sealed record LoyaltyHandling2 : OpenStringEnum<LoyaltyHandling2>
{
    private LoyaltyHandling2(string value) : base(value)
    {
    }

    public static readonly LoyaltyHandling2 Forbidden = new("Forbidden");

    public static readonly LoyaltyHandling2 Processed = new("Processed");

    public static readonly LoyaltyHandling2 Allowed = new("Allowed");

    public static readonly LoyaltyHandling2 Proposed = new("Proposed");

    public static readonly LoyaltyHandling2 Required = new("Required");

    public TResult Match<TResult>(Func<TResult> onForbidden,
        Func<TResult> onProcessed,
        Func<TResult> onAllowed,
        Func<TResult> onProposed,
        Func<TResult> onRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Forbidden => onForbidden(),
            _ when this == Processed => onProcessed(),
            _ when this == Allowed => onAllowed(),
            _ when this == Proposed => onProposed(),
            _ when this == Required => onRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onForbidden,
        Action onProcessed,
        Action onAllowed,
        Action onProposed,
        Action onRequired,
        Action<string> otherwise)
    {
        if (this == Forbidden) onForbidden();
        else if (this == Processed) onProcessed();
        else if (this == Allowed) onAllowed();
        else if (this == Proposed) onProposed();
        else if (this == Required) onRequired();
        else otherwise(Value);
    }
}
