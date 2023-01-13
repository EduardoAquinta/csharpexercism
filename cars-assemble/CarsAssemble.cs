using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed) =>
    
        speed switch {
            (> 0) and (< 5) => 1.0,
            (> 4) and (< 9) => .90,
            9 => .80,
            10 => .77,
            _ => 0
        };
    
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * (speed * 221);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
