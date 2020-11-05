using Data_Objects_Layer;
using Logic_Layer; 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Data_Objects_Layer.Shape;

namespace Final_Project
{
    public partial class frmMain : Form
    {
        private bool playing { get; set; }
        private static int blockSize = 27;
        private static int numRows = 15;
        private static int numCols = 20;
        private int baseTickInterval = 450;
        private bool paused;
        private Moves input = new Moves();
        private GameField GameField;
        private Dictionary<string, Block> boardBlocks = new Dictionary<string, Block>();

        public frmMain()
        {
            InitializeComponent();
            this.GameField = new GameField();
            this.drawBackgroundGrid();
            this.paused = false;
            KeyDown += new KeyEventHandler(frmMain_KeyDown);
        }

        private void drawBackgroundGrid()
        {
            foreach (KeyValuePair<string, Block> i in boardBlocks)
            {
                i.Value.Dispose();
            }
            boardBlocks.Clear();
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Block block = new Block(row, col);
                    block.Top = row * blockSize;
                    block.Left = col * blockSize;
                    boardBlocks.Add(blockSpace(row, col), block);
                }
            }
        }

        private string blockSpace(int row, int col)
        {
            return row.ToString() + col.ToString();
        }

        private void reset()
        {
            this.resetTextFields();
            this.GameField = new GameField();
            this.playing = true;
            this.timer.Interval = this.baseTickInterval;
            this.timer.Enabled = true;
        }

        private void resetTextFields()
        {
            this.txtScoreArea.Text = "0";
        }

        private void updateGameBoard()
        {
            Block block;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    boardBlocks.TryGetValue(blockSpace(row, col), out block);
                    block.blockColor = GameField.grid[row, col];
                }
            }
            Shape shapes = GameField.currentShapes;
            for (int row = 0; row < shapes.currShape.GetLength(0); row++)
            {
                for (int col = 0; col < shapes.currShape.GetLength(1); col++)
                {
                    Coordinate i = new Coordinate(col, row);
                    i = shapes.toBoardCoord(i);
                    if (shapes.currShape[row, col] && i.x >= 0 && i.x < numCols && i.y < numRows)
                    {
                        boardBlocks.TryGetValue(blockSpace(i.y, i.x), out block);
                        block.blockColor = shapes.shapesColor;
                    }
                }
            }
        }
        private void gameOver()
        {
            this.timer.Enabled = false;
            this.playing = false;
            this.lblGameStatus.Text = "GAME OVER!";
            this.updateGameBoard();
        }

        public new void Move(Direction directionToMove, int distanceToMove)
        {
            switch (directionToMove)
            {
                case Direction.Left:
                    Location = new Point((Location.X - distanceToMove), Location.Y);
                    break;
                case Direction.Right:
                    Location = new Point((Location.X + distanceToMove), Location.Y);
                    break;
                default:
                    break;
            }
        }

        private void frmMain_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (playing)
            {
                if (input.leftKey)
                    GameField.moveCurrentShapeLeft();
                if (input.rightKey)
                    GameField.moveCurrentShapeRight();
            }
            input.keyControls(e.KeyCode, false);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (playing)
                input.keyControls(e.KeyCode, true);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (this.paused == false)
            {
                btnPause.Text = "Start";
                this.timer.Enabled = false;
                this.playing = false;
                this.paused = true;
            }
            else if (this.paused == true)
            {
                btnPause.Text = "Pause";
                this.timer.Enabled = true;
                this.playing = true;
                this.paused = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                this.updateGameBoard();
            }
        }

        private void frmMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
