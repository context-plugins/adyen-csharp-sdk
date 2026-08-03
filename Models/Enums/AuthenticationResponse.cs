using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// In 3D Secure 2, this is the <c>transStatus</c> from the challenge result. If the transaction was frictionless, omit this parameter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthenticationResponse>))]
public sealed record AuthenticationResponse : StringEnum<AuthenticationResponse>
{
    private AuthenticationResponse(string value) : base(value)
    {
    }

    public static readonly AuthenticationResponse Y = new("Y");

    public static readonly AuthenticationResponse N = new("N");

    public static readonly AuthenticationResponse U = new("U");

    public static readonly AuthenticationResponse A = new("A");

    public static AuthenticationResponse FromValue(string value) => FromValueCore(value);
}
