using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The <see href="https://docs.adyen.com/issuing/transaction-rules#outcome">outcome</see> that will be applied when a transaction meets the conditions of the rule.
/// <para>
/// Possible values:
/// * <b>hardBlock</b> (default): the transaction is declined.
/// * <b>scoreBased</b>: the transaction is assigned the <c>score</c> you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined. This value is not allowed when <c>requestType</c> is <b>bankTransfer</b>.
/// </para>
/// <list type="bullet">
///   <item><description><b>enforceSCA</b>: your user is prompted to verify their identity using <see href="https://docs.adyen.com/issuing/3d-secure/">3D Secure authentication</see>. If the authentication fails or times out, the transaction is declined. This value is only allowed when <c>requestType</c> is <b>authentication</b>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutcomeType>))]
public sealed record OutcomeType : StringEnum<OutcomeType>
{
    private OutcomeType(string value) : base(value)
    {
    }

    public static readonly OutcomeType EnforceSca = new("enforceSCA");

    public static readonly OutcomeType HardBlock = new("hardBlock");

    public static readonly OutcomeType ScoreBased = new("scoreBased");

    public static readonly OutcomeType TimedBlock = new("timedBlock");

    public static OutcomeType FromValue(string value) => FromValueCore(value);
}
