using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class TetrisWindow : UserControl
    {
        Bitmap Buffer;
        Graphics BuffersGraphics;
        private Block[,] blocks;

        public TetrisWindow()
        {
            InitializeComponent();
            Blocks = new Block[10, 20];
            prepareBoard();
            Buffer = new Bitmap(Width, Height);
            BuffersGraphics = Graphics.FromImage(Buffer); 
        }

        internal Block[,] Blocks { get => blocks; set => blocks = value; }

        public void prepareBoard()
        { //initialises/resets board
            for (int x = 0 ; x < 10 ; x++)
            {
                for (int y = 0 ; y < 20 ; y++)
                {
                    Blocks[x, y] = new Block();
                }
            }
        }

        private void TetrisWindow_Paint(object sender, PaintEventArgs e)
        { //draws board to buffer then draws the buffer
            Block tempblock;
            BuffersGraphics.Clear(Color.Transparent);
            BuffersGraphics.DrawRectangle(new Pen(Color.Black, 2), 1, 1, Width - 1, Height - 1);
            for (int x = 0 ; x < 10 ; x++)
            {
                for (int y = 0 ; y < 20 ; y++)
                {
                    tempblock = Blocks[x, y];
                    if (tempblock.getFilled())
                    {
                        BuffersGraphics.FillRectangle(tempblock.getColor(), x * (Width / 10), y * (Height / 10), Width / 10, Height / 20);
                    }
                    BuffersGraphics.DrawRectangle(Pens.Black, x * (Width / 10), y * (Height / 20), Width / 10, Height / 20);
                }
            } // Drawing to Buffer


            e.Graphics.DrawImage(Buffer, 0, 0); // Buffer To Screen
        }
    }
}
