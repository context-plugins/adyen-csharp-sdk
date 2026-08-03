using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Notification message. It informs about the outcome of the operation. Possible values:
/// * CREATED
/// * ALREADY_EXISTS
/// * ERROR
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreationResultCode>))]
public sealed record CreationResultCode : StringEnum<CreationResultCode>
{
    private CreationResultCode(string value) : base(value)
    {
    }

    public static readonly CreationResultCode AlreadyExists = new("ALREADY_EXISTS");

    public static readonly CreationResultCode Created = new("CREATED");

    public static readonly CreationResultCode Error = new("ERROR");

    public static CreationResultCode FromValue(string value) => FromValueCore(value);
}
