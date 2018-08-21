using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris
{
    class Piece
    {
        Random randomGenerator;
        private PieceType typeOfPiece;

        public Piece()
        {
            randomGenerator = new Random();
        }

        public Brush getPieceColor()
        {
            switch (typeOfPiece)
            {
                case PieceType.I:
                    return Brushes.LightBlue;
                case PieceType.O:
                    return Brushes.Yellow;
                case PieceType.T:
                    return Brushes.Purple;
                case PieceType.S:
                    return Brushes.LimeGreen;
                case PieceType.Z:
                    return Brushes.Red;
                case PieceType.J:
                    return Brushes.Blue;
                case PieceType.L:
                    return Brushes.Orange;
            }
            return Brushes.Transparent;
        }

        public PieceType generateNextPiece()
        {// TODO add piece generation http://tetris.wikia.com/wiki/Random_Generator
            return (PieceType)randomGenerator.Next(0, 6);
        }

        public bool checkCollision(Block[,] Board)
        { // checks for any pieces that are marked as falling, then checks if they are at the bottom or if there is a piece below it.
            for (int x = 0 ; x < 10 ; x++)
            {
                for (int y = 0 ; y < 20 ; y++)
                {
                    if (Board[x, y].getFalling())
                    {
                        if (y == 19 || Board[x, y + 1].getFilled())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public enum PieceType
        {
            I = 0,
            O = 1,
            T = 2,
            S = 3,
            Z = 4,
            J = 5,
            L = 6
        }
    }
}
