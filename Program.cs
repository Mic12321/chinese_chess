class Program
{
  static void Main(string[] args)
  {
    ChineseChess chineseChess = new ChineseChess();


    while (chineseChess.gameRun)
    {
      System.Console.WriteLine(chineseChess.currentPlayer.roleColour + " Turn");
      chineseChess.showBoard();
      chineseChess.playerInput();
      chineseChess.changeCurrentPlayer();
    }

  }
}