using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of the payment. Possible values:
/// <list type="bullet">
///   <item><description><b>Success</b> – The operation has been completed successfully.</description></item>
///   <item><description><b>Refused</b> – The operation was refused. The reason is given in the <c>refusalReason</c> field.</description></item>
///   <item><description><b>Error</b> – There was an error when the operation was processed. The reason is given in the <c>refusalReason</c> field.</description></item>
///   <item><description><b>NotEnoughBalance</b> – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResultCode3>))]
public sealed record ResultCode3 : OpenStringEnum<ResultCode3>
{
    private ResultCode3(string value) : base(value)
    {
    }

    public static readonly ResultCode3 Success = new("Success");

    public static readonly ResultCode3 Refused = new("Refused");

    public static readonly ResultCode3 Error = new("Error");

    public static readonly ResultCode3 NotEnoughBalance = new("NotEnoughBalance");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onRefused,
        Func<TResult> onError,
        Func<TResult> onNotEnoughBalance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Refused => onRefused(),
            _ when this == Error => onError(),
            _ when this == NotEnoughBalance => onNotEnoughBalance(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess,
        Action onRefused,
        Action onError,
        Action onNotEnoughBalance,
        Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Refused) onRefused();
        else if (this == Error) onError();
        else if (this == NotEnoughBalance) onNotEnoughBalance();
        else otherwise(Value);
    }
}
