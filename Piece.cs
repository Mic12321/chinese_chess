class Piece {
    public Colour colour { set; get; }

    protected bool isMoveOneBackward(Location currentLocation, Location targetLocation)
    {
        return (currentLocation.row==targetLocation.row-1);
    }

    protected bool isRowSame(Location currentLocation, Location targetLocation) 
    {
        return (currentLocation.row==targetLocation.row);
    }

    protected bool isMoveOneForward(Location currentLocation, Location targetLocation) 
    {
        return (currentLocation.row==targetLocation.row+1);
    }

    protected bool isColumnSame(Location currentLocation, Location targetLocation) 
    {
        return (currentLocation.column==targetLocation.column);
    }

    protected bool isMoveOneVertical(Location currentLocation, Location targetLocation)
    {
        return (currentLocation.row==targetLocation.row+1 || currentLocation.row==targetLocation.row-1);
    }

    protected bool isMoveOneHorizontal(Location currentLocation, Location targetLocation)
    {
        return (currentLocation.column==targetLocation.column+1 || currentLocation.column==targetLocation.column-1);
    }

    protected bool isMoveOneAdjacent(Location currentLocation, Location targetLocation)
    {
        return (isMoveOneHorizontal(currentLocation, targetLocation) && isMoveOneVertical(currentLocation, targetLocation));
    }

    protected bool isSamePosition(Location currentLocation, Location targetLocation)
    {
        return (currentLocation.column == targetLocation.column && currentLocation.row == targetLocation.row);
    }

    // Check does the target location has the same colour piece
    protected bool isTargetLocationGetBlocked(Location targetLocation, Board board)
    {
        return (board.grid[targetLocation.column, targetLocation.row].colour == colour);
    }

    protected bool isOnBoard(Location targetLocation, Board board) {
        return (0 < targetLocation.column && 
                targetLocation.column < (board.column + 1) && 
                0 < targetLocation.row && 
                targetLocation.row < (board.row + 1));
    }

    ///////////
    public bool isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        return false;
    }

    // Flip the piece row of location only from lower to upper
    protected Location flipLocationToUpper(Location location, Board board) 
    {
        location.column = board.rowHalf - location.column;

        return location;
    }
}    