using System.Collections.Generic;

class Board
{

  public Piece[,] grid { set; get; }

  public int length { set; get; }

  public int wide { set; get; }

  // private void initBoard() 
  // {
  //   for (int i = 0; i < size; ++i) 
  //   { 
  //     for (int j = 0; j < size; ++j) 
  //     {
  //       grid[i,j] = new Piece(Colour.None);
  //     }  
  //   }
  // }

  // public Board(int _long, int _wide)
  // {
  //   size = _size;
  //   grid = new Piece[size, size];
    
  //   initBoard();
  // }

  // public void updatePiece(int row, int column, Colour colour) 
  // {
  //   grid[row, column] = new Piece(Colour.None);
  // }
  
}