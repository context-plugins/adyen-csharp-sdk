using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The operation performed on the token. Possible values:
/// <list type="bullet">
///   <item><description><b>created</b>: the token has been created.</description></item>
///   <item><description><b>updated</b>: the existing token has been updated.</description></item>
///   <item><description><b>alreadyExisting</b>: the details have already been stored.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenizationStoreOperationType>))]
public sealed record TokenizationStoreOperationType : StringEnum<TokenizationStoreOperationType>
{
    private TokenizationStoreOperationType(string value) : base(value)
    {
    }

    public static readonly TokenizationStoreOperationType Created = new("created");

    public static readonly TokenizationStoreOperationType Updated = new("updated");

    public static readonly TokenizationStoreOperationType AlreadyExisting = new("alreadyExisting");

    public static TokenizationStoreOperationType FromValue(string value) => FromValueCore(value);
}
