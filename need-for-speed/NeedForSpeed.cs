using System;
class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }
    private int battery;
    private int distance;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        battery = 100;
        distance = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
        return (this.battery - BatteryDrain) < 0;
    }
    public int DistanceDriven()
    {
        return this.distance;
    }
    public void Drive()
    {
        if (!BatteryDrained())
        {
            this.distance += Speed;
            this.battery -= BatteryDrain;
        }
    }
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}
class RaceTrack
{
    private readonly int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        int drives = (100/car.BatteryDrain);
        int possibleDistance = drives*car.Speed;
        return (possibleDistance >= this.distance);
    }
}