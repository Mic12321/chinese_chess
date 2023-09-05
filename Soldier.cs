class Soldier : Piece
{
    private bool initLocationIsUpper;

    public Soldier(Colour _colour, Location location) 
    {
        colour = _colour;

        if (location.row==3) { initLocationIsUpper=true; }
        else if (location.row==6) { initLocationIsUpper=false; }
    }
    
    private bool isValidMoveBeforeRiver(Location currentLocation, Location targetLocation) 
    {
        return (isMoveOneForward(currentLocation, targetLocation) && (isRowSame(currentLocation, targetLocation)));
    }

    private bool _isValidMove(Location currentLocation, Location targetLocation) 
    {
        
        // Before crossing river
        if (currentLocation.row<5) 
        {
            return isValidMoveBeforeRiver(currentLocation, targetLocation);
        }

        // Crossed river
        else {
            return (isValidMoveBeforeRiver(currentLocation, targetLocation) || (isMoveOneHorizontal(currentLocation, targetLocation) && (isColumnSame(currentLocation, targetLocation))));
        }
    }

    public bool isValidMove(Location currentLocation, Location targetLocation, Board board) 
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        else if (isTargetLocationGetBlocked(targetLocation, board)) { return false; }

        else if (initLocationIsUpper) { return _isValidMove(currentLocation, targetLocation); }
        else { return _isValidMove(flipLocationToUpper(currentLocation, board), flipLocationToUpper(targetLocation, board)); }
    }
    
}