using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Position
    {
        //gettery i settery
        public int Row { get; set; }
        public int Column { get; set; }

        //konstruktor (SKRÓTY CTRL + .)
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }
}
