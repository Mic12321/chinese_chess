class Canon : Piece
{
    public Canon(Colour _colour) 
    {
        colour = _colour;
    }

    private Colour opponentColour()
    {
        if (colour==Colour.Black) { return Colour.Red; }
        else { return Colour.Black; }
    }

    // Improve required
    private bool _isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        int byPass=0;

        if (isColumnSame(currentLocation, targetLocation))
        {
            if (currentLocation.row > targetLocation.row)
            {
                for (int i = currentLocation.row -1 ; i>=targetLocation.row; --i)
                {
                    if (board.grid[currentLocation.column, i].colour!=Colour.None)
                    {
                        byPass+=1;

                        if (byPass==1 && i==targetLocation.row) { return false; }

                        if (byPass==2 && i!=targetLocation.row) { return false; }
                    }
                }
            }

            else 
            {
                for (int i = currentLocation.row+1 ; i<=targetLocation.row; ++i)
                {
                    if (board.grid[currentLocation.column, i].colour!=Colour.None)
                    {
                        byPass+=1;

                        if (byPass==1 && i==targetLocation.row) { return false; }

                        if (byPass==2 && i!=targetLocation.row) { return false; }
                    }
                }
            }
        }
        else
        {
            if (currentLocation.column > targetLocation.column)
            {
                for (int i = currentLocation.column -1 ; i>=targetLocation.column; --i)
                {
                    if (board.grid[i, currentLocation.row].colour!=Colour.None)
                    {
                        byPass+=1;

                        if (byPass==1 && i==targetLocation.column) { return false; }

                        if (byPass==2 && i!=targetLocation.column) { return false; }
                    }
                }
            }

            else 
            {
                for (int i = currentLocation.column+1 ; i<=targetLocation.column; ++i)
                {
                    if (board.grid[i, currentLocation.row].colour!=Colour.None)
                    {
                        byPass+=1;

                        if (byPass==1 && i==targetLocation.column) { return false; }

                        if (byPass==2 && i!=targetLocation.column) { return false; }
                    }
                }
            }
        }

        // No pieces on the path
        if (byPass == 0) { return true; }

        // Allow to jump a piece when captureing an opponenet's piece
        else if (byPass == 1 && board.grid[targetLocation.column, targetLocation.row].colour==opponentColour()) { return true; }

        return false;
    }


    

    public override bool isValidMove(Location currentLocation, Location targetLocation, Board board) 
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        
        if (isColumnSame(currentLocation, targetLocation) ^ isRowSame(currentLocation, targetLocation))
        {
            return (_isValidMove(currentLocation, targetLocation, board));
        }

        return false;
    }
}