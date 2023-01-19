using System;
using System.Diagnostics;

public static class ScrabbleScore
{
    private static int total = 0;
    private static char[] one = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    private static char[] two = { 'D', 'G' };
    private static char[] three = { 'B', 'C', 'M', 'P' };
    private static char[] four = { 'F', 'H', 'V', 'W', 'Y' };
    private static char five = 'K';
    private static char[] eight = { 'J', 'K' };
    private static char[] ten = { 'Q', 'Z' };
    public static int Score(string input)
    {
        foreach (var c in input.ToUpper())
        {
            foreach (var ch in one)
            {
                if (c == ch)
                {
                    Console.WriteLine(input);
                    Console.WriteLine(ch);
                    total += 1;
                }
            }

            foreach (var cb in two)
            {
                if (c == cb)
                {
                    total += 2;
                }
            }
            
            foreach (var cc in three)
            {
                if (c == cc)
                {
                    total += 3;
                }
            }
            
            foreach (var cf in four)
            {
                if (c == cf)
                {
                    total += 4;
                }
            }
            
            if (c == five)
            {
                total += 5;
            }
            
            foreach (var cj in eight)
            {
                if (c == cj)
                {
                    total += 8;
                }
            }
            
            foreach (var cz in ten)
            {
                if (c == cz)
                {
                    total += 10;
                }
            }
        }
        Console.WriteLine(total);
        return total;
    }
}