class WeighingMachine
{
    public WeighingMachine(int precision)
    {
        this.Precision = precision;
    }
    public int Precision { get; }
    // TODO: define the 'Precision' property
    private double weight;
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value >= 0)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    // TODO: define the 'Weight' property

    public double TareAdjustment { get; set; } = 5;
    // TODO: define the 'TareAdjustment' property
    public string DisplayWeight { get { return $"{(weight - TareAdjustment).ToString($"F{Precision}")} kg"; } }
    // TODO: define the 'DisplayWeight' property
}
