using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public class Queen : Piece
    {
        public override string DebugSymbol { get; } = "Q";

        public Queen(Coordinate coordinate) : base(coordinate)
        {
        }

        public override HashSet<Move> GetLegalMoves(Player player, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
