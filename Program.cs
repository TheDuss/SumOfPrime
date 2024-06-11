using System;
using PrimeSum;


class Program
{
    static void Main()
    {
        PrimeCalculator calculator = new PrimeCalculator();
        int count = 1001;

        var primes = calculator.GetFirstNPrimes(count);
        int sum = calculator.SumOfPrimes(primes);

        Console.WriteLine("Summen af de første 1001 primtal er: " + sum);
    }
}