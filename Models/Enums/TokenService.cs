using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The name of the token service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenService>))]
public sealed record TokenService : StringEnum<TokenService>
{
    private TokenService(string value) : base(value)
    {
    }

    public static readonly TokenService Visatokenservice = new("VISATOKENSERVICE");

    public static readonly TokenService Mctokenservice = new("MCTOKENSERVICE");

    public static readonly TokenService Amextokenservice = new("AMEXTOKENSERVICE");

    public static readonly TokenService TokenSharing = new("TOKEN_SHARING");

    public static TokenService FromValue(string value) => FromValueCore(value);
}
