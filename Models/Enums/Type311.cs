using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>genericissuer</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type311>))]
public sealed record Type311 : StringEnum<Type311>
{
    private Type311(string value) : base(value)
    {
    }

    public static readonly Type311 OnlineBankingPl = new("onlineBanking_PL");

    public static readonly Type311 Eps = new("eps");

    public static readonly Type311 OnlineBankingSk = new("onlineBanking_SK");

    public static readonly Type311 OnlineBankingCz = new("onlineBanking_CZ");

    public static readonly Type311 OnlinebankingIn = new("onlinebanking_IN");

    public static Type311 FromValue(string value) => FromValueCore(value);
}
