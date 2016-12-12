using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
{
    public struct Coordinate
    {
        public enum FileLetter
        {
            a = 1,
            b,
            c,
            d,
            e,
            f,
            g,
            h
        }

        public int Rank { get; }
        public FileLetter File { get; }

        public Coordinate(int rank, int file)
        {
            if (rank < 1 || rank > 8 || file < 0 || file > 8)
            {
                throw new ArgumentException($"Invalid coordinate: {file},{rank}");
            }

            Rank = rank;
            File = (FileLetter)file;
        }
        public Coordinate(int rank, FileLetter file) : this(rank, (int) file)
        {
        }

        public override string ToString()
        {
            return File.ToString() + Rank;
        }
    }
}
