using System.Reflection.Metadata.Ecma335;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object? obj)
    {
        if(obj is FacialFeatures other)
        {
            return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object? obj)
    {
        if(obj is Identity other)
        {
            return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures.EyeColor, FacialFeatures.PhiltrumWidth);
    }
}

public class Authenticator
{
    HashSet<Identity> registeredIdentities = new HashSet<Identity>();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA == faceB;
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));
    }

    public bool Register(Identity identity)
    {
        if(!IsRegistered(identity))
        {
            registeredIdentities.Add(identity);
            return true;
        }
        else
            return false;
    }

    public bool IsRegistered(Identity identity)
    {
        return registeredIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        if(identityA == identityB)
            return true;
        else
            return false;
    }
}
