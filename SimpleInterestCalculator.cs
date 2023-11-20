namespace IntrestCalculator
{
    public class SimpleInterestCalculator : IInterestCalculator
    {
        public InterestCalculationResultDTO CalculateInterest(decimal principal, decimal rate, int time, InterestCalculationType calculationType)
        {
            decimal interest = principal * rate/100 * time;
            decimal totalAmount = principal + interest;

            return new InterestCalculationResultDTO
            {
                Principal = principal,
                Interest = interest,
                TotalAmount = totalAmount
            };
        }
    }

}