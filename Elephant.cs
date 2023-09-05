class Elephant : Piece
{
    private bool initLocationIsUpper;

    public Elephant(Colour _colour, Location location)
    {
        colour = _colour;

        if (location.row==3) { initLocationIsUpper=true; }
        else if (location.row==6) { initLocationIsUpper=false; }
    }

    private bool _isValidMove(Location currentLocation, Location targetLocation)
    {
        if (targetLocation.row<5) { return false; }

        if ((currentLocation.column-2==targetLocation.column ||currentLocation.column+2==targetLocation.column) 
            && (currentLocation.row-2==targetLocation.row ||currentLocation.row+2==targetLocation.row))
            {
                return true;
            }

        return false;
    }

    public bool isValidMove(Location currentLocation, Location targetLocation, Board board)
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        else if (isTargetLocationGetBlocked(targetLocation, board)) { return false; }

        else if (initLocationIsUpper) { return _isValidMove(currentLocation, targetLocation); }
        else { return (_isValidMove(flipLocationToUpper(currentLocation, board), flipLocationToUpper(targetLocation, board))); } 
    }
}