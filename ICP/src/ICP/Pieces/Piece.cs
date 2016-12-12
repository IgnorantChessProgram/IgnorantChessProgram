using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public abstract class Piece
    {
        public Coordinate Coordinate { get; set; }

        public abstract HashSet<Move> GetLegalMoves(Player player, Board board);
    }
}
