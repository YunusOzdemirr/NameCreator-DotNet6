namespace NameCreator;

public class Exchange
{
    public decimal CalculateTheExchange(decimal x, decimal diff, decimal diffPercentage = 10, int day = 15)
    {
        decimal firstValue = x;
        decimal money = x;
        for (int i = 0; i < day; i++)
        {
            decimal percentage = (money * diffPercentage) / 100;
            money += percentage;
        }

        diff = firstValue - x;
        return money;
    }

    public decimal ProfitCalculation(int quantity, decimal firstPrice, decimal lastPrice)
    {
        var diff = firstPrice - lastPrice;
        var money = quantity * diff;
        return money;
    }
}