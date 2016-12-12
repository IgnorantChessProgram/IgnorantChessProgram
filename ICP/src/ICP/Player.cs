using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public class Player
    {
        public Dictionary<Coordinate, Piece> Pieces { get; }

        public HashSet<Piece> InactivePieces { get; }

        public TimeSpan TimeOnClock { get; }

        public bool CanCastleKingside { get; }

        public bool CanCastleQueenside { get; }

        public HashSet<Move> LegalMoves { get; }

        public bool IsInCheck { get; }

        public bool IsCheckmated { get; }

        public bool IsStalemate { get; }

        public Player MakeMove(Move move, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
