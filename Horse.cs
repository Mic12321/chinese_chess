class Horse : Piece 
{
    public Horse(Colour _colour) 
    {
        colour = _colour;
    }

    public bool isValidMove(Location currentLocation, Location targetLocation, Board board) 
    {
        if (!isOnBoard(targetLocation, board)) { return false; }
        else if (isTargetLocationGetBlocked(targetLocation, board)) { return false; }

        
        return true;
    }
}