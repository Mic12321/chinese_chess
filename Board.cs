// using System.Collections.Generic;


class Board
{

  public Piece[,] grid { set; get; }

  public int row { set; get; }

  public int column { set; get; }
  public int columnHalf { get { return column/2; } }


  // Close to (0, 0) is colour black side.
  // Close to (8, 0) is colour red side.
  private void initBoard() 
  { 
    grid[0, 0] = new Rook(Colour.Black);
    grid[8, 0] = new Rook(Colour.Black);
    grid[0, 9] = new Rook(Colour.Red);
    grid[8, 9] = new Rook(Colour.Red);

    grid[1, 0] = new Horse(Colour.Black);
    grid[7, 0] = new Horse(Colour.Black);
    grid[1, 9] = new Horse(Colour.Red);
    grid[7, 9] = new Horse(Colour.Red);

    grid[2, 0] = new Elephant(Colour.Black, new Location(2, 0));
    grid[6, 0] = new Elephant(Colour.Black, new Location(6, 0));
    grid[2, 9] = new Elephant(Colour.Red, new Location(2, 9));
    grid[6, 9] = new Elephant(Colour.Red, new Location(6, 9));

    grid[3, 0] = new Guard(Colour.Black, new Location(3, 0));
    grid[5, 0] = new Guard(Colour.Black, new Location(5, 0));
    grid[3, 9] = new Guard(Colour.Red, new Location(3, 9));
    grid[5, 9] = new Guard(Colour.Red, new Location(5, 9));

    grid[4, 0] = new King(Colour.Black, new Location(4, 0));
    grid[4, 9] = new King(Colour.Red, new Location(4, 9));

    grid[1, 2] = new Canon(Colour.Black);
    grid[7, 2] = new Canon(Colour.Black);
    grid[1, -3] = new Canon(Colour.Red);
    grid[7, -3] = new Canon(Colour.Red);

    grid[0, 3] = new Soldier(Colour.Black, new Location(0, 3));
    grid[2, 3] = new Soldier(Colour.Black, new Location(2, 3));
    grid[4, 3] = new Soldier(Colour.Black, new Location(4, 3));
    grid[6, 3] = new Soldier(Colour.Black, new Location(6, 3));
    grid[8, 3] = new Soldier(Colour.Black, new Location(8, 3));

    grid[0, -4] = new Soldier(Colour.Red, new Location(0, -4));
    grid[2, -4] = new Soldier(Colour.Red, new Location(2, -4));
    grid[4, -4] = new Soldier(Colour.Red, new Location(4, -4));
    grid[6, -4] = new Soldier(Colour.Red, new Location(6, -4));
    grid[8, -4] = new Soldier(Colour.Red, new Location(8, -4));
  }

  public Board()
  {
    row = 9;
    column = 10;

    Piece[,] grid = new Piece[row, column];
    
    initBoard();
  }

  public void movePiece(Location currentLocation, Location targetLocation)
  {
    try {
      grid[targetLocation.column, targetLocation.row] = grid[currentLocation.column, targetLocation.row];
      grid[currentLocation.column, targetLocation.row] = null;
    } catch(System.Exception e) { System.Console.WriteLine(e); }

  }
  
}