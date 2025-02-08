using System;

class Primi
{
    /*static*/ bool IsPrime(int number) //se fosse statica non dovrei instanziare con new Primi() ma solo chiamare IsPrime(i)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int N;
        do {   
            Console.WriteLine("Inserisci un numero N: ");
        } while (!int.TryParse(Console.ReadLine(), out N));

        Console.WriteLine($"I numeri primi tra 1 e {N} sono:");

        for (int i = 2; i <= N; i++)
        {
            if (new Primi().IsPrime(i))
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
