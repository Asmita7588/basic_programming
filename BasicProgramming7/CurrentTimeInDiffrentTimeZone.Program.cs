using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming7
{
    internal class CurrentTimeInDiffrentTimeZoneProgram
    {
          public void CurrentTimeInDifferentTimeZone()
        {
            DateTime utcTime = DateTime.UtcNow;
            utcTime = DateTime.SpecifyKind(utcTime, DateTimeKind.Utc);

            string[] timeZoneIds = {
                "UTC",
                "Pacific Standard Time",
                "Eastern Standard Time", 
                "Central European Standard Time", 
                "India Standard Time", 
                "China Standard Time", 
                "Tokyo Standard Time"
            };

            foreach (string timeZoneId in timeZoneIds)
            {
                try
                {
                    TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                    DateTime localTime = TimeZoneInfo.ConvertTime(utcTime, timeZone);
                    Console.WriteLine($"Time {timeZone} : {localTime.ToString("yyyy-MM-dd HH:mm:ss")}");
                }
                catch (TimeZoneNotFoundException)
                {
                    Console.WriteLine($"Time zone '{timeZoneId}' not found.");
                }
                catch (InvalidTimeZoneException)
                {
                    Console.WriteLine($"Time zone '{timeZoneId}' is invalid.");
                }
            }
        } 
    }
}