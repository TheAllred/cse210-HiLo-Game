
namespace HilowGame // Note: actual namespace depends on the project name.
{
    public class Card
    {
        public int _value;
        Random rnd = new Random();



        public Card()
        {
            _value = rnd.Next(1, 13);  // creates a number between 1 and 13  
        }

    }
}
