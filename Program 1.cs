using System;
using System.Numerics;


namespace Biggly
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            UseBigInteger();
            
        }
      static void  UseBigInteger ()
        {
            BigInteger biggly = BigInteger.Parse("999999999999999999999");
            Console.WriteLine("Bigly is: {0}", biggly);
            Console.WriteLine("Is even: {0}", biggly.IsEven);
            Console.WriteLine("Power of two : {0}", biggly.IsPowerOfTwo);
            BigInteger veryBig = BigInteger.Multiply(biggly, BigInteger.Parse("8888888888888888888"));
                 Console.WriteLine(" the end is: {0}", veryBig);
        }
    }
}
