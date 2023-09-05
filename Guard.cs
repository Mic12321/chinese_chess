class Guard : Piece
{
    private bool initLocationIsUpper;

    public Guard(Colour _colour, Location location) 
    {
        colour = _colour;

        if (location.row==0) { initLocationIsUpper=true; }
        else if (location.row==9) { initLocationIsUpper=false; }
    }     

    private bool _isValidMove(Location currentLocation, Location targetLocation)
    {
        // Check is it inside the correct 9 spots
        if (!((targetLocation.row < 3) && (2 < targetLocation.column) && (targetLocation.column < 6))) { return false; }

        else if (!isMoveOneAdjacent(currentLocation, targetLocation)) { return false; }

        return true;
    }                                                                                                                  
    
    public bool isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        else if (isTargetLocationGetBlocked(targetLocation, board)) { return false; }

        else if (initLocationIsUpper) { return _isValidMove(currentLocation, targetLocation); }
        else { return (_isValidMove(flipLocationToUpper(currentLocation, board), flipLocationToUpper(targetLocation, board))); }
    }
}