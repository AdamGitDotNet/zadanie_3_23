using System;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            bool odgadlLiczbe = false;
            Random liczbaRandom = new Random();
            int wylosowanaLiczba = liczbaRandom.Next(1, 100);
            byte iloscProbOdgadniecia = 1;
            string zmPomocnicza = string.Empty;

            Console.WriteLine("Podaj liczbę z zakresu: 1 - 100");

            do
            {

                if (Int16.TryParse(Console.ReadLine(), out Int16 liczbaUzytkownika))
                {
                    if (liczbaUzytkownika >= 1 && liczbaUzytkownika <= 100)
                    {
                        if (liczbaUzytkownika == wylosowanaLiczba)
                        {
                            if (iloscProbOdgadniecia == 1) { zmPomocnicza = "próbie"; } else { zmPomocnicza = "próbach"; }
                            Console.WriteLine($"\n!!!!!!!!!!!Tak to liczba {liczbaUzytkownika} !!!!!!!!!!.\n");
                            Console.WriteLine($"Odgadłeś po {iloscProbOdgadniecia} {zmPomocnicza}.\n\n");
                            odgadlLiczbe = true;
                        }
                        else
                        {
                            if (liczbaUzytkownika > wylosowanaLiczba) { zmPomocnicza = "mniejsza"; } else { zmPomocnicza = "większa"; }
                            Console.WriteLine($"\nWylosowana liczba jest {zmPomocnicza} od Twojej. Próbuj dalej.\n");
                            iloscProbOdgadniecia++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Podałeś niepoprawną liczbę. Podaj liczbę z zakresu: 1 - 100");
                    }
                }
                else
                {
                    Console.WriteLine($"Podałeś niepoprawne dane. Podaj liczbę z zakresu: 1 - 100");
                }
            }
            while (!odgadlLiczbe);


        }
    }
}