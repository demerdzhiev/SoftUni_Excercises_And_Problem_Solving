using System;

namespace ExExT01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int yearsOld = 18;
          
           
            

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    heritage -= 12000;
                }
                else 
                {
                    heritage -= (12000 + (50 * yearsOld));
                }
                yearsOld++;
            }
            if (heritage < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Abs(heritage):f2} dollars left.");  
            }
        }
    }
}
