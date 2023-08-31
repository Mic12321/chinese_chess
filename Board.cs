using System.Collections.Generic;


class Board
{

  public Piece[,] grid { set; get; }

  public int row { set; get; }

  public int column { set; get; }


  private void initBoard() 
  {
    // foreach (KeyValuePair<Piece, int> kvp in initPieceLocation)
    // {

    // }



    return;

  }

  public Board()
  {
    row = 9;
    column = 10;

    Piece[,] grid = new Piece[row, column];
    
    initBoard();
  }
  
}