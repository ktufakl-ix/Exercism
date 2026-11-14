class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay.Last<int>();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(var i in birdsPerDay)
        {
            if(i == 0 )
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int ans = 0;
        for (int i = 0; i < numberOfDays; i++) {
            ans += birdsPerDay[i];
        }
        return ans;
    }

    public int BusyDays()
    {
        int ans = 0;
        foreach(var i in birdsPerDay)
        {
            if (i >=5)
            {
                ans++;
            }
        }
        return ans;
    }
}
