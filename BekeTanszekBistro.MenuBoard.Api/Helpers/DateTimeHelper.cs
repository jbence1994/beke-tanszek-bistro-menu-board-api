using System;

namespace BekeTanszekBistro.MenuBoard.Api.Helpers
{
    public static class DateTimeHelper
    {
        public static bool Equals(DateTime date)
        {
            var now = DateTime.Now;

            return now.Year == date.Year &&
                   now.Month == date.Month &&
                   now.Day == date.Day;
        }
    }
}
