namespace IntrestCalculator
{
    public class CalculatorMenu
    {
        private IInterestCalculator interestCalculator;

        public CalculatorMenu()
        {
            interestCalculator = new CompoundInterestCalculator(); // Default to compound interest calculator
        }

        public void StartCalculator()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Interest Rate Calculator");
                Console.WriteLine("========================");
                Console.WriteLine("1. Simple Interest");
                Console.WriteLine("2. Compound Interest");
                Console.WriteLine("3. Exit");
                Console.WriteLine("========================");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        interestCalculator = new SimpleInterestCalculator(); 
                        CalculateInterest();
                        break;
                    case "2":
                        interestCalculator = new CompoundInterestCalculator();
                        CalculateInterest();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void CalculateInterest()
        {
            Console.Clear();
            Console.WriteLine("Interest Calculation");
            Console.WriteLine("====================");
            Console.Write("Enter principal amount: ");
            decimal principal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            decimal rate = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter time (in years): ");
            int time = Convert.ToInt32(Console.ReadLine());

            InterestCalculationResultDTO result = interestCalculator.CalculateInterest(principal, rate, time, InterestCalculationType.Compound);

            Console.WriteLine();
            Console.WriteLine("Calculation Result");
            Console.WriteLine("==================");
            Console.WriteLine($"Principal: {result.Principal}");
            Console.WriteLine($"Interest: {result.Interest}");
            Console.WriteLine($"Total Amount: {result.TotalAmount}");
        }
    }
}