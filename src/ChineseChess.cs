class ChineseChess
{
    public Board board { private set; get; }

    public Player redPlayer { private set; get; }

    public Player blackPlayer { private set; get; }

    public Player currentPlayer { private set; get; }
    
    public bool gameRun { private set; get; }

    

    public void changeCurrentPlayer() 
    {
        if (currentPlayer.roleColour == Colour.Black) { currentPlayer = redPlayer; }
        else { currentPlayer = blackPlayer; }
    }

    public void playerInput() 
    {
        bool inputting = true;
        string input;

        while (inputting)
        {
            input = System.Console.ReadLine();

            try 
            {
                string[] split=input.Split(' ');

                Location currentLocation = new Location(int.Parse(split[0]), int.Parse(split[1]));
                Location targetLocation = new Location(int.Parse(split[2]), int.Parse(split[3]));


                if (board.grid[currentLocation.column, currentLocation.row].isValidMove(currentLocation, targetLocation, board)) {

                    board.movePiece(currentLocation, targetLocation);

                    inputting = false;
                }

                else { System.Console.WriteLine("Invalid move"); }

                


            }
            catch (System.FormatException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, format or index issue"); }
            catch (System.IndexOutOfRangeException) { System.Console.WriteLine("Player " + currentPlayer.roleColour + " invalid move, index issue"); }
            catch (System.Exception exception) { System.Console.WriteLine(exception.Message); }

        }
    }


    public void showBoard()
    {
        System.Console.WriteLine();
        
        for (int i = 0; i < board.row; ++i) 
        { 
            for (int j = 0; j < board.column; ++j) 
            {

                if ((board.grid[j,i].colour)==Colour.None)
                {
                    System.Console.Write("NN");
                }

                else 
                {
                    System.Console.Write(board.grid[j,i].colour.ToString()[0]);     // First letter of the colour, "Red" is "R", "Black" is "B"
                    System.Console.Write(board.grid[j,i].GetType().Name[0]);        // First letter of the piece class name, "Rook" is "R", "Horse" is "H", etc.
                }

                System.Console.Write(" ");
            }  

            System.Console.WriteLine();

        }
    }

    private void initBoard()
    {
        // Close to (0, 0) is colour black side.
        // Close to (8, 0) is colour red side.
        board.grid[0, 0] = new Rook(Colour.Black);
        board.grid[8, 0] = new Rook(Colour.Black);
        board.grid[0, 9] = new Rook(Colour.Red);
        board.grid[8, 9] = new Rook(Colour.Red);

        board.grid[1, 0] = new Horse(Colour.Black);
        board.grid[7, 0] = new Horse(Colour.Black);
        board.grid[1, 9] = new Horse(Colour.Red);
        board.grid[7, 9] = new Horse(Colour.Red);

        board.grid[2, 0] = new Elephant(Colour.Black, new Location(2, 0));
        board.grid[6, 0] = new Elephant(Colour.Black, new Location(6, 0));
        board.grid[2, 9] = new Elephant(Colour.Red, new Location(2, 9));
        board.grid[6, 9] = new Elephant(Colour.Red, new Location(6, 9));

        board.grid[3, 0] = new Guard(Colour.Black, new Location(3, 0));
        board.grid[5, 0] = new Guard(Colour.Black, new Location(5, 0));
        board.grid[3, 9] = new Guard(Colour.Red, new Location(3, 9));
        board.grid[5, 9] = new Guard(Colour.Red, new Location(5, 9));

        board.grid[4, 0] = new King(Colour.Black, new Location(4, 0));
        board.grid[4, 9] = new King(Colour.Red, new Location(4, 9));

        board.grid[1, 2] = new Canon(Colour.Black);
        board.grid[7, 2] = new Canon(Colour.Black);
        board.grid[1, 7] = new Canon(Colour.Red);
        board.grid[7, 7] = new Canon(Colour.Red);

        board.grid[0, 3] = new Soldier(Colour.Black, new Location(0, 3));
        board.grid[2, 3] = new Soldier(Colour.Black, new Location(2, 3));
        board.grid[4, 3] = new Soldier(Colour.Black, new Location(4, 3));
        board.grid[6, 3] = new Soldier(Colour.Black, new Location(6, 3));
        board.grid[8, 3] = new Soldier(Colour.Black, new Location(8, 3));

        board.grid[0, 6] = new Soldier(Colour.Red, new Location(0, -4));
        board.grid[2, 6] = new Soldier(Colour.Red, new Location(2, -4));
        board.grid[4, 6] = new Soldier(Colour.Red, new Location(4, -4));
        board.grid[6, 6] = new Soldier(Colour.Red, new Location(6, -4));
        board.grid[8, 6] = new Soldier(Colour.Red, new Location(8, -4));
    }

    public ChineseChess() 
    {
        board = new Board(9, 10);
        initBoard();

        redPlayer = new Player(Colour.Red);
        blackPlayer = new Player(Colour.Black);

        //
        currentPlayer = new Player(Colour.Red);

        gameRun = true;
    }
}