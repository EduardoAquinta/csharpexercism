using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private static readonly HashSet<string> RobotTracker = new();


    public string Name
    {
        get;
        private set;
    }

    public Robot()
    {
        Reset();
    }

    private string GetUniqueName()
    {
        var robotName = RobotName();

        while (!RobotTracker.Add(robotName))
        {
            robotName = RobotName();
        }

        return robotName;
    }

    private string RobotName()
        {

            const int length = 2;
            StringBuilder strBuild = new StringBuilder();
            Random rndLetters = new Random();
            Random rndNumbers = new Random();

            for (int i = 0; i < length; i++)
            {
                double flt = rndLetters.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(26 * flt));
                var letter = Convert.ToChar(shift + 65);
                strBuild.Append(letter);
            }

            var threeRandomNumbers = rndNumbers.Next(100, 999);
            var result = strBuild.ToString() + threeRandomNumbers;

            return result;
        }
    


public void Reset() => Name = GetUniqueName();
}