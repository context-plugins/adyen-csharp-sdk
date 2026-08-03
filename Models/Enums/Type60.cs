using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ebanking_FI</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type60>))]
public sealed record Type60 : StringEnum<Type60>
{
    private Type60(string value) : base(value)
    {
    }

    public static readonly Type60 EbankingFi = new("ebanking_FI");

    public static Type60 FromValue(string value) => FromValueCore(value);
}
