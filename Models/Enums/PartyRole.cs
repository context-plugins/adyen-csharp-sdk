using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PartyRole>))]
public sealed record PartyRole : StringEnum<PartyRole>
{
    private PartyRole(string value) : base(value)
    {
    }

    public static readonly PartyRole Holder = new("HOLDER");

    public static readonly PartyRole AuthorizedUser = new("AUTHORIZED_USER");

    public static readonly PartyRole Other = new("OTHER");

    public static readonly PartyRole Unknown = new("UNKNOWN");

    public static PartyRole FromValue(string value) => FromValueCore(value);
}
