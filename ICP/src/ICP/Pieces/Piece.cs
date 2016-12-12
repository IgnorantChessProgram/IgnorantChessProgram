using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public abstract class Piece
    {
        public Piece(Coordinate coordinate)
        {
            Coordinate = coordinate;
        }

        public Coordinate Coordinate { get; set; }

        public abstract HashSet<Move> GetLegalMoves(Player player, Board board);

        public abstract string DebugSymbol { get; }
    }
}
