using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public class Rook : Piece
    {
        public override string DebugSymbol { get; } = "R";

        public Rook(Coordinate coordinate) : base(coordinate)
        {
        }

        public override HashSet<Move> GetLegalMoves(Player player, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
