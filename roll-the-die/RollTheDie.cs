using System;

public class Player
{
    public int RollDie()
    {
        Random rnd = new Random();
        var answer = rnd.Next(1, 18);
        return answer;
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        var answer = rnd.NextDouble();
        return answer;
    }
}
