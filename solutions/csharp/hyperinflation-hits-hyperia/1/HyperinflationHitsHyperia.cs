public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            checked
            {
                long value = @base*multiplier;
                return value.ToString();
            }
            
        }
        catch (OverflowException e)
        {

            return "*** Too Big ***";
        }   
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        try
        {
            checked
            {
                float value = @base * multiplier;
                if (value == float.PositiveInfinity)
                    return "*** Too Big ***";
                return value.ToString();
            }

        }
        catch (OverflowException e)
        {

            return "*** Too Big ***";
        }
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            checked
            {
                decimal value = salaryBase * multiplier;
                return value.ToString();
            }

        }
        catch (OverflowException e)
        {

            return "*** Much Too Big ***";
        }
    }
}
