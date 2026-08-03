using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Success</b>
/// * <b>Failure</b>
/// * <b>Partial</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result3>))]
public sealed record Result3 : StringEnum<Result3>
{
    private Result3(string value) : base(value)
    {
    }

    public static readonly Result3 Success = new("Success");

    public static readonly Result3 Failure = new("Failure");

    public static readonly Result3 Partial = new("Partial");

    public static Result3 FromValue(string value) => FromValueCore(value);
}
