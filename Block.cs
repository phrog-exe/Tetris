using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffsett { get; }

        public abstract int Id { get; }

        private int rotationState;
        private Position offsett;

        public Block()
        {
            offsett = new Position(StartOffsett.Row, StartOffsett.Column); 
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach(Position p in Tiles[rotationState]) 
            {
                yield return new Position(p.Row + offsett.Row, p.Column + offsett.Column);
            }
        }
        //rotacja według zegara
        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }
        //rotacja przeciwna do zegara
        public void RotateCCW()
        {
            if(rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }

        }
        public void Move(int rows, int columns)
        {
            offsett.Row += rows;
            offsett.Column += columns;
        }
        public void Reset()
        {
            rotationState = 0;
            offsett.Row = StartOffsett.Row;
            offsett.Column = StartOffsett.Column;
                
        }
    }

}
