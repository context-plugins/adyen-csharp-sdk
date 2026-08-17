using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>genericissuer</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type31>))]
public sealed record Type31 : StringEnum<Type31>
{
    private Type31(string value) : base(value)
    {
    }

    public static readonly Type31 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly Type31 Eps = new("eps");

    public static readonly Type31 OnlineBankingSk = new("onlineBanking_SK");

    public static readonly Type31 OnlineBankingCz = new("onlineBanking_CZ");

    public static readonly Type31 OnlinebankingIn = new("onlinebanking_IN");

    public static Type31 FromValue(string value) => FromValueCore(value);
}
