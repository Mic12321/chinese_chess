class Rook : Piece
{

    public Rook(Colour _colour) 
    {
        colour = _colour;
    }

    // Improve required
    private bool isBlocked(Location currentLocation, Location targetLocation, Board board) 
    {
        if (isColumnSame(currentLocation, targetLocation)) { 
            if (currentLocation.row > targetLocation.row)
            {
                
                for (int i=currentLocation.row; i>targetLocation.row; --i)
                {
                    if (board.grid[currentLocation.column, i - 1].colour!=Colour.None) 
                    { 
                        if(board.grid[currentLocation.column, i - 1].colour==colour) { return false; }
                        else { return (targetLocation.row==i - 1); }
                    }
                }
            }

            else {

                for (int i=currentLocation.row; i<targetLocation.row; ++i)
                {
                    if (board.grid[currentLocation.column, i + 1].colour!=Colour.None) 
                    { 
                        if(board.grid[currentLocation.column, i + 1].colour==colour) { return false; }
                        else { return (targetLocation.row==i + 1); }
                    }
                }
            }
        }
        else {

            if (currentLocation.row > targetLocation.row) {
                for (int i=currentLocation.column; i>targetLocation.column; --i)
                {
                    if (board.grid[i - 1, currentLocation.column].colour!=Colour.None) 
                    { 
                        if(board.grid[i - 1, currentLocation.column].colour==colour) { return false; }
                        else { return (targetLocation.column==i - 1); }
                    }
                }
            }

            else {
                for (int i=currentLocation.column; i<targetLocation.column; ++i)
                {
                    if (board.grid[i + 1, currentLocation.column].colour!=Colour.None) 
                    { 
                        if(board.grid[i + 1, currentLocation.column].colour==colour) { return false; }
                        else { return (targetLocation.column==i + 1); }
                    }
                }
            }
        }

        return true;
    }

    public override bool isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        
        if (isColumnSame(currentLocation, targetLocation) ^ isRowSame(currentLocation, targetLocation))
        {
            return (isBlocked(currentLocation, targetLocation, board));
        };

        return false;
    }
}