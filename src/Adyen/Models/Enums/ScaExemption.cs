using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of exemption for Strong Customer Authentication (SCA). Possible values:
/// * <b>lowerLimit</b>: the newly created limit is lower than the existing limit.
/// * <b>notRegulated</b>: the limit is created in a country, region, or industry where it is not mandated by law to use SCA.
/// * <b>setByPlatform</b>: you set a limit for one of your user's balance accounts, or for your balance platform.
/// * <b>initialLimit</b>: there are no existing transfer limits set on the balance account or balance platform.
/// * <b>alreadyPerformed</b>: you are confident about your user's identity and do not need to verify this using SCA.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaExemption>))]
public sealed record ScaExemption : OpenStringEnum<ScaExemption>
{
    private ScaExemption(string value) : base(value)
    {
    }

    public static readonly ScaExemption SetByPlatform = new("setByPlatform");

    public static readonly ScaExemption InitialLimit = new("initialLimit");

    public static readonly ScaExemption LowerLimit = new("lowerLimit");

    public static readonly ScaExemption NotRegulated = new("notRegulated");

    public static readonly ScaExemption AlreadyPerformed = new("alreadyPerformed");

    public TResult Match<TResult>(Func<TResult> onSetByPlatform,
        Func<TResult> onInitialLimit,
        Func<TResult> onLowerLimit,
        Func<TResult> onNotRegulated,
        Func<TResult> onAlreadyPerformed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SetByPlatform => onSetByPlatform(),
            _ when this == InitialLimit => onInitialLimit(),
            _ when this == LowerLimit => onLowerLimit(),
            _ when this == NotRegulated => onNotRegulated(),
            _ when this == AlreadyPerformed => onAlreadyPerformed(),
            _ => otherwise(Value)
        };

    public void Match(Action onSetByPlatform,
        Action onInitialLimit,
        Action onLowerLimit,
        Action onNotRegulated,
        Action onAlreadyPerformed,
        Action<string> otherwise)
    {
        if (this == SetByPlatform) onSetByPlatform();
        else if (this == InitialLimit) onInitialLimit();
        else if (this == LowerLimit) onLowerLimit();
        else if (this == NotRegulated) onNotRegulated();
        else if (this == AlreadyPerformed) onAlreadyPerformed();
        else otherwise(Value);
    }
}
