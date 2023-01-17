using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeeksBirds = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeeksBirds;
    }

    public int Today()
    {
        int todayCount = birdsPerDay.Last();
        return todayCount;
    }

    public void IncrementTodaysCount()
    {
        int lastElement = birdsPerDay.Length - 1;
        birdsPerDay[lastElement] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool truth = false;
        foreach (var day in birdsPerDay)
        {
            if (day == 0)
            {
                truth = true;
            }
        }
        return truth;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (var i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                count += 1;
            }
        }

        return count;
    }
}
