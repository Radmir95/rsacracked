using System;
using System.Numerics;

namespace RSA
{
    public static class RSA
    {
       
        public static BigInteger Sqrt( BigInteger n)
        {
            if (n == 0) return 0;
            if (n <= 0) throw new ArithmeticException("NaN");
            var bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
            var root = BigInteger.One << (bitLength / 2);

            while (!isSqrt(n, root))
            {
                root += n / root;
                root /= 2;
            }

            return root;
        }
        public static bool isSqrt(BigInteger n, BigInteger root)
        {
            var lowerBound = root * root;
            var upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

    }
}
