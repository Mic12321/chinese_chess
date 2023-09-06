class Elephant : Piece
{
    private bool initLocationIsUpper;

    public Elephant(Colour _colour, Location location)
    {
        colour = _colour;

        if (location.row==0) { initLocationIsUpper=true; }
        else if (location.row==9) { initLocationIsUpper=false; }
    }

    private bool isBlocked(Location currentLocation, Location targetLocation, Board board)
    {
        int midPointColumn = (currentLocation.column+targetLocation.column)/2;
        int midPointRow = (currentLocation.row+targetLocation.row)/2;

        return (board.grid[midPointColumn, midPointRow]!=null);
    }

    private bool _isValidMove(Location currentLocation, Location targetLocation)
    {
        if (targetLocation.row<5) { return false; }

        else if ((currentLocation.column-2==targetLocation.column ||currentLocation.column+2==targetLocation.column) 
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

        if (isBlocked(currentLocation, targetLocation, board)) { return false; }

        if (initLocationIsUpper) { return _isValidMove(currentLocation, targetLocation); }
        else { return (_isValidMove(flipLocationToUpper(currentLocation, board), flipLocationToUpper(targetLocation, board))); } 
    }
}