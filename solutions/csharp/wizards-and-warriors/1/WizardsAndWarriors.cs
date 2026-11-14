abstract class Character
{
    public string ct;
    protected Character(string characterType)
    {
        ct = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {ct}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {

    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;
    }
}

class Wizard : Character
{
    public bool prepared = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (prepared)
            return 12;
        else
            return 3;
    }

    public void PrepareSpell()
    {
        prepared = true;
    }
    public override bool Vulnerable()
    {
        if (!prepared)
            return true;
        else
            return false;
    }
}
