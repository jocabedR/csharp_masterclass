using System;

static class AssemblyLine
{
    const int producedCarsPerHour = 221;
    
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0.0;
        if(speed >= 1 && speed <= 4) return 1.0;
        if(speed >= 5 && speed <= 8) return 0.9;
        if(speed == 9) return 0.8;
        if(speed == 10) return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * SuccessRate(speed) * producedCarsPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed)/ 60;
    }
}
