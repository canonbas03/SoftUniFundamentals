namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                int playerOneCard = playerOne[0];
                int playerTwoCard = playerTwo[0];

                playerOne.Remove(playerOneCard);
                playerTwo.Remove(playerTwoCard);

                if (playerOneCard > playerTwoCard)
                {
                    playerOne.Add(playerOneCard);
                    playerOne.Add(playerTwoCard);
                }
                else if (playerTwoCard > playerOneCard)
                {
                    playerTwo.Add(playerTwoCard);
                    playerTwo.Add(playerOneCard);
                }
            }
            if(playerOne.Count > playerTwo.Count)
            {
                int sumOfCards = playerOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sumOfCards}");
            }
            else
            {
                int sumOfCards = playerTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sumOfCards}");
            }
        }
    }
}
