namespace IntrestCalculator
{
    public interface IInterestCalculator
    {
        InterestCalculationResultDTO CalculateInterest(decimal principal, decimal rate, int time, InterestCalculationType calculationType);
    }
}