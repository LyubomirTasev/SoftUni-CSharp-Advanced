using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDiffInDays(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime datetwo = DateTime.Parse(secondDate);

            int daysDifference = Math.Abs((dateOne - datetwo).Days);
            return daysDifference;
        }
    }
}
