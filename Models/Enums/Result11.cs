using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Result of the processing of the message.
/// Possible values:
/// * <b>Failure</b>
/// * <b>Partial</b>
/// * <b>Success</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result11>))]
public sealed record Result11 : StringEnum<Result11>
{
    private Result11(string value) : base(value)
    {
    }

    public static readonly Result11 Success = new("Success");

    public static readonly Result11 Failure = new("Failure");

    public static readonly Result11 Partial = new("Partial");

    public static Result11 FromValue(string value) => FromValueCore(value);
}
