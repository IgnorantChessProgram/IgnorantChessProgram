using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICP;

namespace EngineConsole
{
    public class EngineConsole
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            Console.Write(board.DebugString());
            Console.ReadLine();
        }
    }
}
