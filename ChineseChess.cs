class ChineseChess
{
    public Board board { private set; get; }

    public Player redPlayer { private set; get; }

    public Player blackPlayer { private set; get; }

    private Player currentPlayer;

    private bool playerPassed;
    
    private bool gameRun;

    public ChineseChess() 
    {
        playerPassed = false;
    }

    private void changeCurrentPlayer() 
    {
        if (currentPlayer.roleColour == Colour.Black) { currentPlayer = redPlayer; }
        else { currentPlayer = blackPlayer; }
    }

    private void gameFinish() 
    {
        gameRun = false;
        System.Console.WriteLine("Game is finished, thanks for playing");
    }

    private void pass()
    {
        if (playerPassed) {
            gameFinish();
        }
        else {
            playerPassed = true;
        }
    }

    private void eachRoundSetUp()
    {
        
    }

    public void playerInput() 
    {
        bool inputting = true;
        string input;

        while (inputting)
        {
            input = System.Console.ReadLine();

            if (input=="pass")
            {
                pass();
                break;
            }

            else {
                try 
                {
                    string[] split=input.Split(' ');

                    int pieceRow = int.Parse(split[0]);
                    int pieceColumn = int.Parse(split[1]);
                    int newRow = int.Parse(split[2]);
                    int newColumn = int.Parse(split[3]);



                    // If move is valid
                    playerPassed = false;

                }
                catch (System.FormatException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, format or index issue"); }
                catch (System.IndexOutOfRangeException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, index issue"); }
                catch (System.Exception exception) { System.Console.WriteLine(exception.Message); }
            }


            
        }
    }
}