﻿using BasicProgramming7;

internal class Program
{
    private static void Main(string[] args)
    {
        //CurrentTimeInDiffrentTimeZoneProgram currentTimeInDiffrentTimeZoneProgram = new CurrentTimeInDiffrentTimeZoneProgram();
        //currentTimeInDiffrentTimeZoneProgram.CurrentTimeInDifferentTimeZone();

        WorkDayCalculator workDayCalculator = new WorkDayCalculator();
        int workedDay= workDayCalculator.CalculateWorkDay();
        Console.WriteLine("Total work day " + workedDay);
    }
}