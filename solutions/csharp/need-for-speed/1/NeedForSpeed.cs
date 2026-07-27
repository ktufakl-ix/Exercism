class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed;
    public int batteryDrain;
    private int battery = 100;
    private int distanceDriven;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (battery <batteryDrain)
            return true;
        else
        {
            return false;
        }
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (battery >= batteryDrain)
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
        else
        {
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        int max_time = 100 / car.batteryDrain;
        if (max_time * car.speed >= distance)
        {
            return true;
        }
        else
            return false;
    }
}
