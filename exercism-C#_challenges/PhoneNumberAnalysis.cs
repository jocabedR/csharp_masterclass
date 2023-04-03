using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork, IsFake;
        string LocalNumber;
        IsNewYork = phoneNumber.Substring(0, 3) == "212" ? true : false;
        IsFake = phoneNumber.Substring(4, 3) == "555" ? true : false;
        LocalNumber = phoneNumber.Substring(8, 4);
        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
