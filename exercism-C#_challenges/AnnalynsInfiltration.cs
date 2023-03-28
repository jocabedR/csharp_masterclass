using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake ||  archerIsAwake || prisonerIsAwake) return true;
        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake) return true;
        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent){
            if(!archerIsAwake) return true;
            return false;
        } else {
            if (prisonerIsAwake && !knightIsAwake && !archerIsAwake) return true;
            return false;
        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
