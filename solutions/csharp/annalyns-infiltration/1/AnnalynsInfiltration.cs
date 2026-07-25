static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake && archerIsAwake)
            return false;
        if ((!knightIsAwake && !archerIsAwake) && (prisonerIsAwake || petDogIsPresent))
            return true;
        if(knightIsAwake^archerIsAwake)
        {
            if (!knightIsAwake && archerIsAwake)
                return false;
            if (!petDogIsPresent)
                return false;
            else
                return true;
        }
        return false;
    }
}

