public abstract class Account
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public abstract void CalculateInterest();
}

public class OrdinaryAccount : Account
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;
        else if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}

public class SalaryAccount : Account
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}

public static class Calculator
{
    public static void CalculateInterest(Account account)
    {
        account.CalculateInterest();
    }
}

