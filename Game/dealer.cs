
namespace HilowGame // Note: actual namespace depends on the project name.
{
    public class Dealer
    {
        public int score = 300;
        public void guess()
        {
            string Hilow = "L";
            string guessNumber;
            Card oldCard = new Card();
            Console.WriteLine($"The first card is {oldCard._value}");
            Console.WriteLine("Will the next card be higher or lower? [H or L]");
            while (true)
            {
                guessNumber = Console.ReadLine().ToUpper();
                if (guessNumber == "H" || guessNumber == "L")
                {
                    break;
                }
            }
            Card newCard = new Card();
            Console.WriteLine($"The second card is {newCard._value}");
            if (newCard._value > oldCard._value)
            {
                Hilow = "H";
            }
            else
            {
                Hilow = "L";
            }
            if (Hilow == guessNumber)
            { score = score + 100; }
            else
            {
                score = score - 75;
            }
            Console.WriteLine($"Your score is [{score}]");
        }
        public Dealer()
        {
            Console.WriteLine("Dealer: Care to play a game?");
        }
    }
}
