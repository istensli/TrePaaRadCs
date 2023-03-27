namespace TrePaaRadCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board();
            GameConsole gameConsole = new GameConsole();
            

            while (true)
            {
                gameConsole.Show(gameBoard);

                if(gameBoard.checkForWinner())
                { 
                    Console.WriteLine("Computer vinner!");
                    break;
                }

                if (gameBoard.checkIfBoardIsFull())
                {
                    Console.WriteLine("Brettet er fullt");
                    gameConsole.Show(gameBoard);
                    break;
                }
                
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();

                if(gameBoard.Mark(position, true) == 1) continue;

                if (gameBoard.checkForWinner())
                {
                    Console.WriteLine("Spiller vinner!");
                    break;
                }

                if (gameBoard.checkIfBoardIsFull())
                {
                    Console.WriteLine("Brettet er fullt");
                    gameConsole.Show(gameBoard);
                    break;
                }


                Thread.Sleep(2000);
                gameBoard.MarkRandom(false);
            }
        }
    }
}