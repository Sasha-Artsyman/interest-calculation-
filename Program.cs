using System;

class EasyPercent
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите сумму: ");
        double sum = Convert.ToDouble(Console.ReadLine());
        int percent = 0;
        int bonus = 0;

        if (sum < 100)
        {
            percent = 5;
        }
        else if (sum >= 100 && sum < 200)
        {
            percent = 7;
        }
        else
        {
            percent = 10;
            bonus = 15;
        }
        Console.WriteLine("сумма к уплате: {0} USD", sum * (percent + 100) / 100 + bonus);

        Console.ReadLine();
    }
}