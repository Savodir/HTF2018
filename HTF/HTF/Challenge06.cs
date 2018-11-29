using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge06 : Challenge
    {
        List<Value> values = new List<Value>();

        DayOfWeek day;
        DateTime start;
        DateTime end;
        public Challenge06()
        {
            get();
            crack();
            Thread.Sleep(11000);
            post();
        }
        public override void crack()
        {
            String strStart = inputValues.ElementAt(0).data.Substring(0,inputValues.ElementAt(0).data.IndexOf(" "));
            String strEnd = inputValues.ElementAt(1).data.Substring(0, inputValues.ElementAt(0).data.IndexOf(" "));
            Trace.WriteLine("Start " + strStart);
            Trace.WriteLine("End" + strEnd);
            start = DateTime.Parse(strStart, new CultureInfo("en-US", true));
            // start = DateTime.Parse(strStart);
            end = DateTime.Parse(strEnd, new CultureInfo("en-US", true));
            String dayofweek = inputValues.ElementAt(2).data;
            Trace.WriteLine(dayofweek);
            switch (dayofweek)
            {
                case "monday":
                    day = DayOfWeek.Monday;
                    break;
                case "tuesday":
                    day = DayOfWeek.Tuesday;
                    break;
                case "wednesday":
                    day = DayOfWeek.Wednesday;
                    break;
                case "thursday":
                    day = DayOfWeek.Thursday;
                    break;
                case "friday":
                    day = DayOfWeek.Friday;
                    break;
                case "saturday":
                    day = DayOfWeek.Saturday;
                    break;
                case "sunday":
                    day = DayOfWeek.Sunday;
                    break;
            }
        TimeSpan ts = end - start;                       // Total duration
                int count = (int)Math.Floor(ts.TotalDays / 7);   // Number of whole weeks
                int remainder = (int)(ts.TotalDays % 7);         // Number of remaining days
                int sinceLastDay = (int)(end.DayOfWeek - day);   // Number of days since last [day]
                if (sinceLastDay < 0) sinceLastDay += 7;         // Adjust for negative days since last [day]

                // If the days in excess of an even week are greater than or equal to the number days since the last [day], then count this one, too.
                if (remainder >= sinceLastDay) count++;
            Trace.WriteLine("Count" + count);
            values.Add(new Value("count", count.ToString()));
        }

        public override void get()
        {
            root = getManager.get("c75839cd76514443767d923aec1f70cd");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            postManager.postChallenge("c75839cd76514443767d923aec1f70cd", MainWindow.identifier, root.id, values);
        }


    }

}
