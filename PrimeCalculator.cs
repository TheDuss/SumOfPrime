namespace PrimeSum
{
    public class PrimeCalculator
    {
        public List<int> GetFirstNPrimes(int count)
        {
            List<int> primes = new List<int>();
            int number = 2;

            while (primes.Count < count)
            {
                if (PrimeChecker.IsPrime(number))
                {
                    primes.Add(number);
                }
                number++;
            }

            return primes;
        }

        public int SumOfPrimes(List<int> primes)
        {
            int sum = 0;
            foreach (int prime in primes)
            {
                sum += prime;
            }

            return sum;
        }
    }
}