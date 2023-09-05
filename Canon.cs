class Canon : Piece
{
    public Canon(Colour _colour) 
    {
        colour = _colour;
    }

    public bool isValidMove(Location currentLocation, Location targetLocation, Board board) 
    {
        return true;
    }
}