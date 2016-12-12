using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ICP.FileLetter;

namespace ICP
{
    public class Board
    {
        public Board()
        {
            White = new Player();
            White.Pieces[new Coordinate(a, 1)] = new Rook(new Coordinate(a, 1));
            White.Pieces[new Coordinate(b, 1)] = new Knight(new Coordinate(b, 1));
            White.Pieces[new Coordinate(c, 1)] = new Bishop(new Coordinate(c, 1));
            White.Pieces[new Coordinate(d, 1)] = new Queen(new Coordinate(d, 1));
            White.Pieces[new Coordinate(e, 1)] = new King(new Coordinate(e, 1));
            White.Pieces[new Coordinate(f, 1)] = new Bishop(new Coordinate(f, 1));
            White.Pieces[new Coordinate(g, 1)] = new Knight(new Coordinate(g, 1));
            White.Pieces[new Coordinate(h, 1)] = new Rook(new Coordinate(h, 1));

            White.Pieces[new Coordinate(a, 2)] = new Pawn(new Coordinate(a, 2));
            White.Pieces[new Coordinate(b, 2)] = new Pawn(new Coordinate(b, 2));
            White.Pieces[new Coordinate(c, 2)] = new Pawn(new Coordinate(c, 2));
            White.Pieces[new Coordinate(d, 2)] = new Pawn(new Coordinate(d, 2));
            White.Pieces[new Coordinate(e, 2)] = new Pawn(new Coordinate(e, 2));
            White.Pieces[new Coordinate(f, 2)] = new Pawn(new Coordinate(f, 2));
            White.Pieces[new Coordinate(g, 2)] = new Pawn(new Coordinate(g, 2));
            White.Pieces[new Coordinate(h, 2)] = new Pawn(new Coordinate(h, 2));


            Black = new Player();
            Black.Pieces[new Coordinate(a, 8)] = new Rook(new Coordinate(a, 8));
            Black.Pieces[new Coordinate(b, 8)] = new Knight(new Coordinate(b, 8));
            Black.Pieces[new Coordinate(c, 8)] = new Bishop(new Coordinate(c, 8));
            Black.Pieces[new Coordinate(d, 8)] = new Queen(new Coordinate(d, 8));
            Black.Pieces[new Coordinate(e, 8)] = new King(new Coordinate(e, 8));
            Black.Pieces[new Coordinate(f, 8)] = new Bishop(new Coordinate(f, 8));
            Black.Pieces[new Coordinate(g, 8)] = new Knight(new Coordinate(g, 8));
            Black.Pieces[new Coordinate(h, 8)] = new Rook(new Coordinate(h, 8));

            Black.Pieces[new Coordinate(a, 7)] = new Pawn(new Coordinate(a, 7));
            Black.Pieces[new Coordinate(b, 7)] = new Pawn(new Coordinate(b, 7));
            Black.Pieces[new Coordinate(c, 7)] = new Pawn(new Coordinate(c, 7));
            Black.Pieces[new Coordinate(d, 7)] = new Pawn(new Coordinate(d, 7));
            Black.Pieces[new Coordinate(e, 7)] = new Pawn(new Coordinate(e, 7));
            Black.Pieces[new Coordinate(f, 7)] = new Pawn(new Coordinate(f, 7));
            Black.Pieces[new Coordinate(g, 7)] = new Pawn(new Coordinate(g, 7));
            Black.Pieces[new Coordinate(h, 7)] = new Pawn(new Coordinate(h, 7));
        }

        public Player White { get; set; }

        public Player Black { get; set; }

        public Piece this[Coordinate key]
        {
            get
            {
                if (White.Pieces.ContainsKey(key))
                {
                    return White.Pieces[key];
                }
                if (Black.Pieces.ContainsKey(key))
                {
                    return Black.Pieces[key];
                }
                return null;
            }
        }

        public string DebugString()
        {
            StringBuilder builder = new StringBuilder();
            for (int rank = 8; rank >= 1; rank--)
            {
                for (int file = 1; file <= 8; file++)
                {
                    Piece piece = this[new Coordinate(file, rank)];
                    if (piece != null)
                    {
                        builder.Append(piece.DebugSymbol + " ");
                    }
                    else
                    {
                        builder.Append("- ");
                    }
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
