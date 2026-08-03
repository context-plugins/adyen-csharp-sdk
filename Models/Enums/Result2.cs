using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of this operation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result2>))]
public sealed record Result2 : StringEnum<Result2>
{
    private Result2(string value) : base(value)
    {
    }

    public static readonly Result2 ActiveRecurringTokenExists = new("ACTIVE_RECURRING_TOKEN_EXISTS");

    public static readonly Result2 AlreadyProcessed = new("ALREADY_PROCESSED");

    public static readonly Result2 PaymentNotFound = new("PAYMENT_NOT_FOUND");

    public static readonly Result2 Success = new("SUCCESS");

    public static Result2 FromValue(string value) => FromValueCore(value);
}
