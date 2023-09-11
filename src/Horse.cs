class Horse : Piece 
{
    public Horse(Colour _colour) 
    {
        colour = _colour;
    }

    public override bool isValidMove(Location currentLocation, Location targetLocation, Board board) 
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        else if (isTargetLocationGetBlocked(targetLocation, board)) { return false; }

        
        int columnDifference = System.Math.Abs(currentLocation.column-targetLocation.column);
        int rowDifference = System.Math.Abs(currentLocation.row-targetLocation.row);

        if (columnDifference==1 && rowDifference==2) 
        {
            return(board.grid[currentLocation.column, currentLocation.row+(targetLocation.row-currentLocation.row)/2].colour==Colour.None); 
        }
        
        else if (columnDifference==2 && rowDifference==1)
        { 
            return(board.grid[currentLocation.column+(targetLocation.column-currentLocation.column)/2, currentLocation.row].colour==Colour.None);  
        }

        return false;
    }
}