public class RemoteControlCar
{
    public RemoteControlCar() {
        Telemetry = new TelemetryController(this);   
    }
    public string CurrentSponsor { get; private set; }
    public ITelemetry Telemetry { get; }
    private Speed currentSpeed;
    // TODO encapsulate the methods suffixed with "_Telemetry" in their own class
    // dropping the suffix from the method name
/*    public void Calibrate_Telemetry()
    {

    }

    public bool SelfTest_Telemetry()
    {
        
    }

    public void ShowSponsor_Telemetry(string sponsorName)
    {
        SetSponsor(sponsorName);
    }

    public void SetSpeed_Telemetry(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
        if (unitsString == "cps")
        {
            speedUnits = SpeedUnits.CentimetersPerSecond;
        }

        SetSpeed(new Speed(amount, speedUnits));
    }
*/
    public interface ITelemetry
    {
        void Calibrate();
        bool SelfTest();
        void ShowSponsor(string sponsorName);
        void SetSpeed(decimal amount, string unitsString);
    }
    public class TelemetryController : ITelemetry
    {
        private readonly RemoteControlCar car;
        public TelemetryController(RemoteControlCar car) {
            this.car = car;
        }
        public void Calibrate()
        {
        }

        public bool SelfTest()
        {
            return true;
        }

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            car.SetSpeed(new Speed(amount, speedUnits));
        }

        public void ShowSponsor(string sponsorName)
        {
            car.SetSponsor(sponsorName);
        }
    }
    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    private void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;

    }

    private void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}

public struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }

    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
        {
            unitsString = "centimeters per second";
        }

        return Amount + " " + unitsString;
    }
}
