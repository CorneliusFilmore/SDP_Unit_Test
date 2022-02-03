using System;

namespace CheckPrimeNumber
{
    public static class CheckPrimeNumbers
    {
        public static bool NumberIsPrime(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be lower than 0!");
            }
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
