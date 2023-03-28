using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance >= 0) {
            if (balance < 1000) return 0.5f;
            if(balance < 5000) return 1.621f;
            return 2.475f;
        } else return 3.213f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while(balance < targetBalance){
            years++;
            balance = AnnualBalanceUpdate(balance);
        }
        return years;
    }
}
