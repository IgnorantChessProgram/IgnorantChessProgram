using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICP
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

    public struct Coordinate
    {
        public int Rank { get; }
        public FileLetter File { get; }

        public Coordinate(int file, int rank)
        {
            if (rank < 1 || rank > 8 || file < 0 || file > 8)
            {
                throw new ArgumentException($"Invalid coordinate: {file},{rank}");
            }

            Rank = rank;
            File = (FileLetter)file;
        }
        public Coordinate(FileLetter file, int rank) : this((int)file, rank)
        {
        }

        public override string ToString()
        {
            return File.ToString() + Rank;
        }
    }
}
