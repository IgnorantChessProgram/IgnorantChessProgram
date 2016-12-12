using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public class Pawn : Piece
    {
        public override string DebugSymbol { get; } = "p";

        public Pawn(Coordinate coordinate) : base(coordinate)
        {
        }

        public override HashSet<Move> GetLegalMoves(Player player, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
