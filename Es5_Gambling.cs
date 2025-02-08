using System;

class Program
{
    static Random random = new Random();

    static int LanciaDadi()
    {
        int dado1 = random.Next(1, 7);
        int dado2 = random.Next(1, 7);
        return dado1 + dado2;
    }

    static void Main()
    {
        double saldo = 1000;

        Console.WriteLine("Benvenuto al gioco di CRAPS!");

        while (true)
        {
            double puntata;
            Console.WriteLine($"\nSaldo attuale: {saldo}");
            do
            {
                Console.Write($"Inserisci l'importo della puntata (max saldo disponibile {saldo} ): ");
            } while (!double.TryParse(Console.ReadLine(), out puntata) || puntata <= 0 || puntata > saldo);

            int sommaDadi = LanciaDadi();
            Console.WriteLine($"Hai lanciato i dadi... La somma è: {sommaDadi}");

            if (sommaDadi == 7 || sommaDadi == 11)
            {
                Console.WriteLine("Hai vinto");
                saldo += puntata;
            }
            else if (sommaDadi == 2 || sommaDadi == 3 || sommaDadi == 12)
            {
                Console.WriteLine("Hai perso");
                saldo -= puntata;
            }
            else
            {
                int punteggio = sommaDadi;
                Console.WriteLine($"Il tuo punteggio è {punteggio}. Devi continuare a lanciare i dadi fino a ottenere {punteggio} o 7.");

                while (true)
                {
                    int nuovoLancio = LanciaDadi();
                    Console.WriteLine($"Hai lanciato i dadi... La somma è: {nuovoLancio}");

                    if (nuovoLancio == punteggio)
                    {
                        // Il tiratore vince se esce il punteggio
                        Console.WriteLine("Hai vinto! Hai ottenuto il tuo punteggio!");
                        saldo += puntata;
                        break;
                    }
                    else if (nuovoLancio == 7)
                    {
                        // Il tiratore perde se esce 7
                        Console.WriteLine("Hai perso! È uscito un 7.");
                        saldo -= puntata;
                        break;
                    }
                }
            }

            if (saldo <= 0)
            {
                Console.WriteLine("\nHai finito i soldi! Game Over. Stop gambling");
                break;
            }
            else
            {
                // Chiedi al giocatore se vuole continuare a giocare
                Console.Write("Vuoi continuare a giocare? (s/n): ");
                string risposta = Console.ReadLine().ToLower();
                if (risposta == "n")
                {
                    Console.WriteLine("\nIl tuo saldo finale è: " + saldo);
                    return;
                }
            }
        }
    }
}
