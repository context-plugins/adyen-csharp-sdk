using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Result>))]
public sealed record Result : StringEnum<Result>
{
    private Result(string value) : base(value)
    {
    }

    public static readonly Result Valid = new("VALID");

    public static readonly Result Invalid = new("INVALID");

    public static readonly Result Unknown = new("UNKNOWN");

    public static readonly Result NotRequired = new("NOT_REQUIRED");

    public static Result FromValue(string value) => FromValueCore(value);
}
