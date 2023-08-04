using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    public class DateModifier
    {
        public int CalculateDateDifferences(string firstDate, string secondDate)
        {
            DateTime date1 = DateTime.ParseExact(firstDate, "yyyy MM dd", null);
            DateTime date2 = DateTime.ParseExact(secondDate, "yyyy MM dd", null);

            TimeSpan difference = date2 - date1;

            return Math.Abs(difference.Days);
        }
    }
}
