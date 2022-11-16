using System;

namespace BegbyOnsdagOppg
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // #1
      // Console.WriteLine("Enter a number to get amount of digits: ");
      // var entry = Convert.ToInt64(Console.ReadLine());
      // var result = CountDigits(entry);
      // Console.WriteLine("Amount of digits in " + entry + " is " + result);
      // Console.WriteLine("Press any key to exit");
      // Console.ReadKey();

      // #2
      Console.WriteLine("Enter a number to get amount of digits: ");
      var entry2 = Convert.ToInt64(Console.ReadLine());
      var result2 = CountDigitsWhile(entry2);
      Console.WriteLine("Number of digits in " + entry2 + " is " + result2);
      
      // #3
      Console.WriteLine("###########################################");
      var result3 = CountDigitsWhile(3256);
      Console.WriteLine("Number of digits in " + 3256 + " is " + result3);
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
      
    }
    
    private static int CountDigitsWhile(long n)
    {
      var digits = n < 0 ? 2 : 1;
      while ((n /= 10L) != 0L) ++digits;
      return digits;
    }

    private static int CountDigits(long n)
    {
      if (n >= 0)
      {
        if (n < 10L) return 1;
        if (n < 100L) return 2;
        if (n < 1000L) return 3;
        if (n < 10000L) return 4;
        if (n < 100000L) return 5;
        if (n < 1000000L) return 6;
        if (n < 10000000L) return 7;
        if (n < 100000000L) return 8;
        if (n < 1000000000L) return 9;
        if (n < 10000000000L) return 10;
        if (n < 100000000000L) return 11;
        if (n < 1000000000000L) return 12;
        if (n < 10000000000000L) return 13;
        if (n < 100000000000000L) return 14;
        if (n < 1000000000000000L) return 15;
        if (n < 10000000000000000L) return 16;
        if (n < 100000000000000000L) return 17;
        if (n < 1000000000000000000L) return 18;
        return 19;
      }
      else
      {
        if (n > -10L) return 2;
        if (n > -100L) return 3;
        if (n > -1000L) return 4;
        if (n > -10000L) return 5;
        if (n > -100000L) return 6;
        if (n > -1000000L) return 7;
        if (n > -10000000L) return 8;
        if (n > -100000000L) return 9;
        if (n > -1000000000L) return 10;
        if (n > -10000000000L) return 11;
        if (n > -100000000000L) return 12;
        if (n > -1000000000000L) return 13;
        if (n > -10000000000000L) return 14;
        if (n > -100000000000000L) return 15;
        if (n > -1000000000000000L) return 16;
        if (n > -10000000000000000L) return 17;
        if (n > -100000000000000000L) return 18;
        if (n > -1000000000000000000L) return 19;
        return 20;
        
      }
      
    }
    private static int CountDigitsLog(long n) =>
      n == 0L ? 1 : (n > 0L ? 1 : 2) + (int)Math.Log10(Math.Abs((double)n));
    

  }
}
