using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies a role or capacity of the party in relation to the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRole2>))]
public sealed record PartyRole2 : StringEnum<PartyRole2>
{
    private PartyRole2(string value) : base(value)
    {
    }

    public static readonly PartyRole2 Holder = new("HOLDER");

    public static readonly PartyRole2 AuthorizedUser = new("AUTHORIZED_USER");

    public static readonly PartyRole2 Other = new("OTHER");

    public static readonly PartyRole2 Unknown = new("UNKNOWN");

    public static PartyRole2 FromValue(string value) => FromValueCore(value);
}
