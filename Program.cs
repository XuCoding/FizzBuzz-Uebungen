namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
            //Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

            //Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
            //Beispiel: 4 % 2 == 0


            {
                // FizzBuzz von 1 bis 100
                for (int i = 1; i <= 100; i++)
                {
                    // Hier überprüfe ich ob die Zahl durch 3 und 5 teilbar ist
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    // Hier überprüfe ich, ob die Zahl nur durch 3 teilbar ist
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    // Hier überprüfe ich ob die Zahl nur durch 5 teilbar ist
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    // Wenn die Zahl weder durch 3 noch durch 5 teilbar ist
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }
}

