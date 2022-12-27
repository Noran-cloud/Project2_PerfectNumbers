


using System;

public class Perfect_Numbers
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Please,enter first number ");
       int num1 = int.Parse(Console.ReadLine());
       
       Console.WriteLine("Please,enter last number ");
       int num2 = int.Parse(Console.ReadLine());
       
       Console.WriteLine("Perfect numbers between them are :");
       
       for (int i = num1; i <= num2; i++)
       {
           int sum = 0;
          for (int j = 1; j < i; j++)
          {
              if (i % j == 0)
              sum+= j;
          }
          if (sum == i)
         Console.Write("{0},",i);
       }
    }
}
