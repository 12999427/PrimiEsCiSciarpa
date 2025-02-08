using System;

class Program
{

    static int MCD(int a, int b) { //metodo mio. altrimenti si poteva usare il metodo di euclide più efficiente
        int divis = Math.Min(a, b);
    
        while (divis > 1) {
    
            if (a % divis == 0 && b % divis == 0)
                break;
            divis--;
        }
        return divis;
    }

    static void Main()
    {
        int ordine1, ordine2;

        do
        {
            Console.WriteLine("Inserisci la quantità di pezzi nel primo ordine");
        } while (!int.TryParse(Console.ReadLine(), out ordine1) || ordine1 <= 0);

        do
        {
            Console.WriteLine("Inserisci la quantità di pezzi nel secondo ordine");
        } while (!int.TryParse(Console.ReadLine(), out ordine2) || ordine2 <= 0);

        int mcd = MCD(ordine1, ordine2);

        Console.WriteLine($"Il massimo comune divisore (MCD) delle quantità è: {mcd}");

        int gruppiOttimizzati = ordine1 / mcd;
        Console.WriteLine($"Puoi organizzare i pezzi in lotti da {mcd} pezzi.");

    }
}
