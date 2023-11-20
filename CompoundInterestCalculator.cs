namespace IntrestCalculator
{
    public class CompoundInterestCalculator : IInterestCalculator
    {
        public InterestCalculationResultDTO CalculateInterest(decimal principal, decimal rate, int time, InterestCalculationType calculationType)
        {
            decimal totalAmount = principal * (decimal)Math.Pow((double)(1 + (rate/100)), time);
            decimal interest = totalAmount - principal;

            return new InterestCalculationResultDTO
            {
                Principal = principal,
                Interest = interest,
                TotalAmount = totalAmount
            };
        }
    }

}