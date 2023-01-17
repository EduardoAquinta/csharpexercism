using System;

class RemoteControlCar
{
    private int _battery = 100;
    private int _distance = 0;

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        string message = $"Driven {_distance} meters";
        return message;
    }

    public string BatteryDisplay()
    {
        return EmptyBattery();
    }

    private string EmptyBattery()
    {
        string message = $"Battery at {_battery}%";
        if (_battery == 0)
        {
            string emptyBattery = "Battery empty";
            return emptyBattery;
        }

        return message;
    }

    public void Drive()
    {
        if (_battery == 0)
        {
            _distance = 2000;
            _battery = 0;
        }
        else
        {
            _distance += 20;
            _battery -= 1;
        }
    }
}
