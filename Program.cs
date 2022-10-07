using System;


namespace HilowGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dealer Dealer = new Dealer();
            Dealer.guess();
            while (true)
            {
                if (Dealer.score > 0)
                {
                    Console.WriteLine("Play again? [Y or N]");
                    string userInputYN = Console.ReadLine().ToUpper();
                    while (true)
                    {
                        if (userInputYN == "Y" || userInputYN == "N")
                        {
                            break;
                        }
                    }
                    if (userInputYN == "Y")
                    {
                        Dealer.guess();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You lost all your money! Thanks for playing.");
                    break;
                }
            }

        }
    }
}
