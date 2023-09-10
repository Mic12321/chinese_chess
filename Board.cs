// using System.Collections.Generic;


class Board
{

  public Piece[,] grid { set; get; }

  public int column { get; }
  public int row { get; }

  public int rowHalf { get { return row/2; } }


  public Board(int _column, int _row)
  {
    column = _column;
    row = _row;

    grid = new Piece[column, row];

    for (int i = 0; i < row; ++i) 
    { 
      for (int j = 0; j < column; ++j) 
      {
        grid[j,i] = new Piece();
      }  
    }
  }


  public void movePiece(Location currentLocation, Location targetLocation)
  {
    try {
      grid[targetLocation.column, targetLocation.row] = grid[currentLocation.column, targetLocation.row];
      grid[currentLocation.column, targetLocation.row] = new Piece();
    } catch(System.Exception e) { System.Console.WriteLine(e); }

  }
  
}