using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public class Bishop : Piece
    {
        public override string DebugSymbol { get; } = "B";

        public Bishop(Coordinate coordinate) : base(coordinate)
        {
        }

        public override HashSet<Move> GetLegalMoves(Player player, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
