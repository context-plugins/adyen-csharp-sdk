using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>openinvoice</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type39>))]
public sealed record Type39 : StringEnum<Type39>
{
    private Type39(string value) : base(value)
    {
    }

    public static readonly Type39 Openinvoice = new("openinvoice");

    public static readonly Type39 AfterpayDirectdebit = new("afterpay_directdebit");

    public static readonly Type39 AtomePos = new("atome_pos");

    public static Type39 FromValue(string value) => FromValueCore(value);
}
