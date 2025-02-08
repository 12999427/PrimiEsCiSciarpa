using System;

class Program
{
    static void Main()
    {
        int numMonete = 0;
        float tot = 0;
        Console.WriteLine(@"Immetti un numero che corrisponde a una moneta:
        1 -> 1 cent     2 -> 2 cent     3 -> 5 cent
        4 -> 10 cent    5 -> 20 cent    6 -> 50 Cent
        7 -> 1 euro     8 -> 2 euro\n");
        while (tot < 5) {
            float moneta;
            do
            {
                Console.WriteLine("Inserici la moneta");
            } while (!float.TryParse(Console.ReadLine(), out moneta) || moneta <= 0 || moneta > 8);
            float valoreMoneta = 0;
            switch (moneta)
            {
                case 1:
                    valoreMoneta = 0.01f;
                    break;
                case 2:
                    valoreMoneta = 0.02f;
                    break;
                case 3:
                    valoreMoneta = 0.05f;
                    break;
                case 4:
                    valoreMoneta = 0.10f;
                    break;
                case 5:
                    valoreMoneta = 0.20f;
                    break;
                case 6:
                    valoreMoneta = 0.50f;
                    break;
                case 7:
                    valoreMoneta = 1.00f;
                    break;
                case 8:
                    valoreMoneta = 2.00f;
                    break;
            }
            tot += valoreMoneta;
            numMonete ++;
            Console.WriteLine($"Prossima moneta - tot: {tot} - numero monete: {numMonete}");
        }
        Console.WriteLine("Hai raggiunto 5 euri");
        Console.WriteLine($"Totale: {tot}");
        Console.WriteLine($"Numero monete: {numMonete}");
    }
}
