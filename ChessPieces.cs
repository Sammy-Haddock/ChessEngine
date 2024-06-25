public class ChessPiece
{
    public ChessPieceType PieceType { get; set; }
    public PieceColor Color { get; set; }

    public ChessPiece(ChessPieceType pieceType, PieceColor color)
    {
        PieceType = pieceType;
        Color = color;
    }
}
