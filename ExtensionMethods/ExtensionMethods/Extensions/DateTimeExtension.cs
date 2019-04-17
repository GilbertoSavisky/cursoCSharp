using System.Globalization;

namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
            else
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
        }
    }
}