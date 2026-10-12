using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Format or protocol for receiving webhooks. Possible values:
/// * <b>soap</b>
/// * <b>http</b>
/// * <b>json</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CommunicationFormat>))]
public sealed record CommunicationFormat : OpenStringEnum<CommunicationFormat>
{
    private CommunicationFormat(string value) : base(value)
    {
    }

    public static readonly CommunicationFormat Http = new("http");

    public static readonly CommunicationFormat Json = new("json");

    public static readonly CommunicationFormat Soap = new("soap");

    public TResult Match<TResult>(Func<TResult> onHttp,
        Func<TResult> onJson,
        Func<TResult> onSoap,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Http => onHttp(),
            _ when this == Json => onJson(),
            _ when this == Soap => onSoap(),
            _ => otherwise(Value)
        };

    public void Match(Action onHttp, Action onJson, Action onSoap, Action<string> otherwise)
    {
        if (this == Http) onHttp();
        else if (this == Json) onJson();
        else if (this == Soap) onSoap();
        else otherwise(Value);
    }
}
