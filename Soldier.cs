class Soldier : Piece
{
    public Soldier(Location _location)
    {
        location = _location;
    }


    // private bool isValidMoveBeforeRiver(Location _location) 
    // {
    //     return (moveOneForward(_location) && (isRowSame(_location)));
    // }

    // public bool isValidMove(Location _location) 
    // {

    //     // Before crossing river
    //     if (location<5) 
    //     {
    //         return validMoveBeforeRiver(_location);
    //     }

    //     // Crossed river
    //     else {
    //         return (validMoveBeforeRiver(_location) || (isMoveOneHorizontal(_location) && (isColumnSame(_location))));
    //     }
        
    // }
    
}