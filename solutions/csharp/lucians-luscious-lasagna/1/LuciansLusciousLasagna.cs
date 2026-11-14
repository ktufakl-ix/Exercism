class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int have_pass)
    {
        return ExpectedMinutesInOven() - have_pass;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int times)
    {
        return times * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int have_pass)
    {
        return PreparationTimeInMinutes(layers) + RemainingMinutesInOven(have_pass);
    }
}
