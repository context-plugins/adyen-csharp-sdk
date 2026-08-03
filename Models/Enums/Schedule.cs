using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payout schedule for the account.
/// <para>
/// Possible values: <c>DEFAULT</c>, <c>DAILY</c>, <c>DAILY_US</c>, <c>DAILY_EU</c>, <c>DAILY_AU</c>, <c>DAILY_SG</c>, <c>WEEKLY</c>, <c>WEEKLY_ON_TUE_FRI_MIDNIGHT</c>, <c>BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT</c>, <c>MONTHLY</c>, <c>HOLD</c>.
/// &gt; <c>HOLD</c> prevents scheduled payouts, but you can still initiate payouts manually.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Schedule>))]
public sealed record Schedule : StringEnum<Schedule>
{
    private Schedule(string value) : base(value)
    {
    }

    public static readonly Schedule BiweeklyOn1StAnd15ThAtMidnight = new("BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT");

    public static readonly Schedule Daily = new("DAILY");

    public static readonly Schedule DailyAu = new("DAILY_AU");

    public static readonly Schedule DailyEu = new("DAILY_EU");

    public static readonly Schedule DailySg = new("DAILY_SG");

    public static readonly Schedule DailyUs = new("DAILY_US");

    public static readonly Schedule Hold = new("HOLD");

    public static readonly Schedule Monthly = new("MONTHLY");

    public static readonly Schedule Weekly = new("WEEKLY");

    public static readonly Schedule WeeklyMonToFriAu = new("WEEKLY_MON_TO_FRI_AU");

    public static readonly Schedule WeeklyMonToFriEu = new("WEEKLY_MON_TO_FRI_EU");

    public static readonly Schedule WeeklyMonToFriUs = new("WEEKLY_MON_TO_FRI_US");

    public static readonly Schedule WeeklyOnTueFriMidnight = new("WEEKLY_ON_TUE_FRI_MIDNIGHT");

    public static readonly Schedule WeeklySunToThuAu = new("WEEKLY_SUN_TO_THU_AU");

    public static readonly Schedule WeeklySunToThuUs = new("WEEKLY_SUN_TO_THU_US");

    public static Schedule FromValue(string value) => FromValueCore(value);
}
