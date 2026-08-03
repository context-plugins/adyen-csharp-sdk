using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Allowed authentication methods: Magswipe, Manual Entry.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthenticationMethod>))]
public sealed record AuthenticationMethod : StringEnum<AuthenticationMethod>
{
    private AuthenticationMethod(string value) : base(value)
    {
    }

    public static readonly AuthenticationMethod Magswipe = new("MAGSWIPE");

    public static readonly AuthenticationMethod Mke = new("MKE");

    public static AuthenticationMethod FromValue(string value) => FromValueCore(value);
}
