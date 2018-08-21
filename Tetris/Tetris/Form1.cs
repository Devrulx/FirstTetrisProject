using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        bool pieceDropping = false;
        Piece droppingPiece = new Piece();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pieceDropping)
            {
                pieceDropping = true;
                switch (droppingPiece.generateNextPiece())
                {
                    case Piece.PieceType.I:

                        break;
                    case Piece.PieceType.J:

                        break;
                    case Piece.PieceType.L:

                        break;
                    case Piece.PieceType.O:

                        break;
                    case Piece.PieceType.S:

                        break;
                    case Piece.PieceType.T:

                        break;
                    case Piece.PieceType.Z:

                        break;
                }
            }

        }
    }
}
