using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            if (candidate % 2 == 0)
            {
                return false;
            }
            
            for (int i = 3; i<= Math.Sqrt(candidate); i++)
                if (candidate % i == 0) return false;

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
