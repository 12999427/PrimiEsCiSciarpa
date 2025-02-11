using System;

class Program
{
    static void Main()
    {
        int livello, numeroEstratto, tentativoUtente, tentativiRimanenti;
        
        int livelloScelto;
        do
        {
            Console.WriteLine("Inserisci il numero del livello (1, 2, 3): ");
        } while (!int.TryParse(Console.ReadLine(), out livelloScelto) || (livelloScelto < 1 || livelloScelto > 3));

        int max = 0;
        switch (livelloScelto)
        {
            case 1:
                max = 5;
                break;
            case 2:
                max = 10;
                break;
            case 3:
                max = 20;
                break;
        }

        Random random = new Random(Environment.TickCount);
        numeroEstratto = random.Next(1, max + 1);
        
        tentativiRimanenti = 8;

        Console.WriteLine("\nIl gioco è iniziato! Il max è " + max);
        do
        {
            int N;
            do
            {
                Console.WriteLine("Inserisci un numero N: ");
            } while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > max);

            // Se è valido
            if (N > numeroEstratto)
            {
                tentativiRimanenti--;
                Console.WriteLine($"NUMERO TROPPO ALTO, HAI A DISPOSIZIONE ANCORA {tentativiRimanenti} TENTATIVI");
            }
            else if (N < numeroEstratto)
            {
                tentativiRimanenti--;
                Console.WriteLine($"NUMERO TROPPO BASSO, HAI A DISPOSIZIONE ANCORA {tentativiRimanenti} TENTATIVI");
            }
            else
            {
                Console.WriteLine("NUMERO ESATTO");
                return; // Il giocatore ha vinto, quindi esce dal gioco
            }

        } while (tentativiRimanenti > 0);

        // Se il giocatore ha esaurito i tentativi
        Console.WriteLine("GAME OVER! Il numero corretto era: " + numeroEstratto);
    }
}
