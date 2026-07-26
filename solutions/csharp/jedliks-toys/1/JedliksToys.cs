using System.Runtime.CompilerServices;

class RemoteControlCar
{
    public int meters = 0;
    public int battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        if (battery <= 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {battery}%";
        }

    }

    public void Drive()
    {
        if (battery > 0)
        {
            meters += 20;
            battery -= 1;
        }
    }
}
