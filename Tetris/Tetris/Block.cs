using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tetris
{
    // Block, contains the information that the tetris window uses to fill in the correct colors and blocks
    class Block
    {
        private Brush fillcolor = Brushes.Transparent; // the color of the block
        private bool filled = false; // whether or not the block is currently filled with a piece or not
        private bool falling = false;

        // variable assignment/retrieval methods
        public void setColor(Brush B)
        {
            fillcolor = B;
        }

        public Brush getColor()
        {
            return fillcolor;
        }

        public void setFilled(bool F)
        {
            filled = F;
        }

        public bool getFilled()
        {
            return filled;
        }

        public void setFalling(bool F)
        {
            falling = F;
        }
        public bool getFalling()
        {
            return falling;
        }
    }
}
