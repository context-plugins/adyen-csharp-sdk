using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>riverty</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type49>))]
public sealed record Type49 : StringEnum<Type49>
{
    private Type49(string value) : base(value)
    {
    }

    public static readonly Type49 Riverty = new("riverty");

    public static readonly Type49 RivertyAccount = new("riverty_account");

    public static readonly Type49 RivertyInstallments = new("riverty_installments");

    public static readonly Type49 SepadirectdebitRiverty = new("sepadirectdebit_riverty");

    public static Type49 FromValue(string value) => FromValueCore(value);
}
