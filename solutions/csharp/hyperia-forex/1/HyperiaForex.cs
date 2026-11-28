public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
    public static bool operator == (CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if(lhs.currency!=rhs.currency)
        {
            throw new ArgumentException();
        }
        else
        {
            if(lhs.amount==rhs.amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency != rhs.currency)
        {
            throw new ArgumentException();
        }
        else
        {
            if (lhs.amount != rhs.amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static bool operator > (CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if(lhs.currency == rhs.currency)
        {
            if (lhs.amount > rhs.amount)
            {
                return true;
            }
            else
                return false;
        }
        else
        {
            throw new ArgumentException();
        }
    }
    public static bool operator < (CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
        {
            if (lhs.amount < rhs.amount)
            {
                return true;
            }
            else
                return false;
        }
        else
        {
            throw new ArgumentException();
        }
    }
    public static decimal operator + (CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount + rhs.amount;
        else
            throw new ArgumentException();
    }
    public static decimal operator -(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount - rhs.amount;
        else
            throw new ArgumentException();
    }
    public static decimal operator *(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount * rhs.amount;
        else
            throw new ArgumentException();
    }
    public static decimal operator /(CurrencyAmount lhs, CurrencyAmount rhs)
    {
        if (lhs.currency == rhs.currency)
            return lhs.amount / rhs.amount;
        else
            throw new ArgumentException();
    }
    public static explicit operator Double(CurrencyAmount value)
    {
        return ((double)value.amount);
    }
    public static implicit operator Decimal(CurrencyAmount value)
    {
        return value.amount;
    }

    // TODO: implement equality operators

    // TODO: implement comparison operators

    // TODO: implement arithmetic operators

    // TODO: implement type conversion operators
}
