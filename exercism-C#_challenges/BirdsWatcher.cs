using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
    }

    public int Today()
    {
        int today = 0;
        foreach (int count in birdsPerDay){
            today = count;
        }
        return today;
    }

    public void IncrementTodaysCount()
    {
        var today = this.birdsPerDay.Length - 1;
        this.birdsPerDay[today]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int count in birdsPerDay) {
            if (count == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for(int i = 0; i < numberOfDays; i++) {
            total += this.birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int bussyDays = 0;
        foreach (int count in this.birdsPerDay) {
            if(count >= 5) bussyDays++;
        }
        return bussyDays;
    }
}
