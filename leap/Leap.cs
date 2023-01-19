using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool truth = false;

        if (year % 100 == 0 && year % 400 != 0)
        {
            return truth;
        }
        if (year % 4 == 0)
        {
            truth = true;
        }

        return truth;
    }
}