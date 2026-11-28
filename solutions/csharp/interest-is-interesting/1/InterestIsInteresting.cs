static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;
        else if (balance >= 0 && balance < 1000)
            return 0.5f;
        else if (balance >= 1000 && balance < 5000)
            return 1.621f;
        else if (balance >= 5000)
            return 2.475f;
        else return 0f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * ((decimal)InterestRate(balance)/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance*(1+((decimal)InterestRate(balance)/100));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int y = 0;
        while(balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            y += 1;
        }
        return y;
    }
}
