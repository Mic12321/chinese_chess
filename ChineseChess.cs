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

    // private void changeCurrentPlayer() 
    // {
    //     if (currentPlayer )
    // }

    private void gameFinish() 
    {
        gameRun = false;
        System.Console.WriteLine("Game is finished, thanks for playing");
    }

    private void PassController(bool isPass)
    {
        if (isPass)
        {
            if (playerPassed) {
                gameFinish();
            }
            else {
                playerPassed = true;
            }
        }
        else {
            playerPassed = false;
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
                PassController(true);
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



                    


                }
                catch (System.FormatException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, format or index issue"); }
                catch (System.IndexOutOfRangeException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, index issue"); }
                catch (System.Exception exception) { System.Console.WriteLine(exception.Message); }
            }


            
        }
    }

    public Location mirrorLocation(Location _location, int columnTotalLength) 
    {
        _location.column=columnTotalLength-_location.column;

        return _location;
    }
}