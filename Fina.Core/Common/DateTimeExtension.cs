namespace Fina.Core.Common;

public static class DateTimeExtension
{
    public static DateTime getFirstDay(this DateTime date, int? year = null, int? month = null)
        => new(year ?? date.Year, month ?? date.Month, 1);

    public static DateTime getLastDay(this DateTime date, int? year = null, int? month = null)
        => new DateTime(year ?? date.Year,month ?? date.Month, 1)
        .AddMonths(1)
        .AddDays(-1);
}
