using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The operation performed on the token. Possible values:
/// <list type="bullet">
///   <item><description><b>created</b>: the token has been created.</description></item>
///   <item><description><b>updated</b>: the existing token has been updated.</description></item>
///   <item><description><b>alreadyExisting</b>: the details have already been stored.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenizationStoreOperationType>))]
public sealed record TokenizationStoreOperationType : OpenStringEnum<TokenizationStoreOperationType>
{
    private TokenizationStoreOperationType(string value) : base(value)
    {
    }

    public static readonly TokenizationStoreOperationType Created = new("created");

    public static readonly TokenizationStoreOperationType Updated = new("updated");

    public static readonly TokenizationStoreOperationType AlreadyExisting = new("alreadyExisting");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onUpdated,
        Func<TResult> onAlreadyExisting,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Updated => onUpdated(),
            _ when this == AlreadyExisting => onAlreadyExisting(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated, Action onUpdated, Action onAlreadyExisting, Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Updated) onUpdated();
        else if (this == AlreadyExisting) onAlreadyExisting();
        else otherwise(Value);
    }
}
