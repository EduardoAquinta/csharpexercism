
static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        var interestRate = 0.0f;
        switch (balance)
        {
            case < 0.0m:
                interestRate =  3.213f;
                break;
            case >= 0m and < 1000.0m:
                interestRate = 0.5f;
                break;
            case >= 1000 and < 5000.0m:
                interestRate = 1.621f;
                break;
            case >= 5000:
                interestRate = 2.475f;
                break;
        }

        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        var interestAmount = 0.0m;

        switch (balance)
        {
            case < 0.0m:
                interestAmount = (balance * 3.213m) / 100.0m;
                break;
            
            case >= 0m and < 1000.0m:
                interestAmount = (balance * 0.5m) / 100.0m;
                break;
            
            case >= 1000.0m and < 5000.0m:
                interestAmount = (balance * 1.621m) / 100.0m;
                break;
            case > 5000.0m:
                interestAmount = (balance * 2.475m) / 100.0m;
                break;
        }
    
        return interestAmount;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        var interestAmount = 0.0m;
        var total = 0.0m;

        switch (balance)
        {
            case < 0.0m:
                interestAmount = (balance * 3.213m) / 100.0m;
                total = interestAmount + balance;
                break;
            
            case >= 0m and < 1000.0m:
                interestAmount = (balance * 0.5m) / 100.0m;
                total = interestAmount + balance;
                break;
            
            case >= 1000.0m and < 5000.0m:
                interestAmount = (balance * 1.621m) / 100.0m;
                total = interestAmount + balance;
                break;
            case > 5000.0m:
                interestAmount = (balance * 2.475m) / 100.0m;
                total = interestAmount + balance;
                break;
        }
    
        return total;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var interestAmount = 0.0m;
        var year = 0;

        while (balance < targetBalance)
        {
            switch (balance)
            {
                case < 0.0m:
                    interestAmount = (balance * 3.213m) / 100.0m;
                    break;

                case >= 0m and < 1000.0m:
                    interestAmount = (balance * 0.5m) / 100.0m;
                    break;

                case >= 1000.0m and < 5000.0m:
                    interestAmount = (balance * 1.621m) / 100.0m;
                    break;
                case > 5000.0m:
                    interestAmount = (balance * 2.475m) / 100.0m;
                    break;
            }

            balance += interestAmount;
            year += 1;
        }

        return year;
    }
}
