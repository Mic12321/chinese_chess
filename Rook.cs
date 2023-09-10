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
                for (int i=currentLocation.row; i!=targetLocation.row; --i)
                {
                    if (board.grid[currentLocation.column, i].colour!=null) 
                    { 
                        if(board.grid[currentLocation.column, i].colour==colour) { return false; }
                        else { return (targetLocation.row==i); }
                    }
                }
            }

            else {
                for (int i=currentLocation.row; i!=targetLocation.row; ++i)
                {
                    if (board.grid[currentLocation.column, i].colour!=null) 
                    { 
                        if(board.grid[currentLocation.column, i].colour==colour) { return false; }
                        else { return (targetLocation.row==i); }
                    }
                }
            }
        }
        else {
            if (currentLocation.row > targetLocation.row) {
                for (int i=currentLocation.column; i!=targetLocation.column; --i)
                {
                    if (board.grid[i, currentLocation.column].colour!=null) 
                    { 
                        if(board.grid[i, currentLocation.column].colour==colour) { return false; }
                        else { return (targetLocation.column==i); }
                    }
                }
            }

            else {
                for (int i=currentLocation.column; i!=targetLocation.column; ++i)
                {
                    if (board.grid[i, currentLocation.column].colour!=null) 
                    { 
                        if(board.grid[i, currentLocation.column].colour==colour) { return false; }
                        else { return (targetLocation.column==i); }
                    }
                }
            }
        }

        return true;
    }

    public bool isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        
        if (isColumnSame(currentLocation, targetLocation) ^ isRowSame(currentLocation, targetLocation))
        {
            return (isBlocked(currentLocation, targetLocation, board));
        };

        return false;
    }
}