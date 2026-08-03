using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Result of the validation. Ex: valid, invalid, unknown
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result1>))]
public sealed record Result1 : StringEnum<Result1>
{
    private Result1(string value) : base(value)
    {
    }

    public static readonly Result1 Valid = new("VALID");

    public static readonly Result1 Invalid = new("INVALID");

    public static readonly Result1 Unknown = new("UNKNOWN");

    public static readonly Result1 NotRequired = new("NOT_REQUIRED");

    public static Result1 FromValue(string value) => FromValueCore(value);
}
