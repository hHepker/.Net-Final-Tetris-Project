using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Data_Objects_Layer
{
   public class GameField
    {
        private static int numRows = 15;
        private static int numCols = 20;
        public int[,] grid = new int[numRows, numCols];
        public int boardColor;
        public int rowsCompleted { get; set; }
        public int Score { get; set; }
        public Shape currentShapes;
        public Coordinate coord;

        public GameField()
        {
            this.rowsCompleted = 0;
            this.Score = 0;
            //this.currentShapes = new Shape();
            this.coord = new Coordinate(0, 0);
            this.colorCodeBoard();
        }

        private void lockShapes()
        {
            if (currentShapes.currShape != null)
            {
                Coordinate i = null;
                int dim = 4;
                for (int row = 0; row < dim; row++)
                {
                    for (int col = 0; col < dim; col++)
                    {
                        if (currentShapes.currShape[row, col])
                        {
                            i = currentShapes.toBoardCoord(new Coordinate(col, row));
                            this.grid[i.y, i.x] = currentShapes.shapesColor;
                        }
                    }
                }
            }
        }

        private bool canBeThere(Shape aShape)
        {
            bool isMoveable = true;
            int dim = 4;

            for (int row = 0; row < dim; row++)
            {
                for (int col = 0; col < dim; col++)
                {
                    if (aShape.currShape[row, col])
                    {
                        Coordinate i = aShape.toBoardCoord(new Coordinate(col, row));
                        if (isBlockFull(i) || i.x >= numCols || i.x < 0 || i.y >= numRows)
                            isMoveable = false;
                    }
                }
            }
            return isMoveable;
        }

        private void NewShapes()
        {
            this.lockShapes();
            this.currentShapes.getNextShape();
        }

        public void moveCurrentShapeLeft()
        {
            if (this.moveSideToSide(true))
                this.currentShapes.x--;
        }

        public void moveCurrentShapeRight()
        {
            if (this.moveSideToSide(false))
                this.currentShapes.x++;
        }

        private bool moveSideToSide(bool left)
        {
            bool isMoveable = true;
            Shape whenMoved = currentShapes.Clone();
            if (left)
                whenMoved.x--;
            else
                whenMoved.x++;
            if (!canBeThere(whenMoved))
                isMoveable = false;
            return isMoveable;
        }

        private bool isBlockFull(Coordinate i)
        {
            if (i.x < numCols && i.x >= 0 && i.y < numRows && i.y >= 0 
                && this.grid[i.y, i.x] == this.boardColor)
                return false;
            return true;
        }

        private bool rowFull(int currentRow)
        {
            for (int col = 0; col < numCols; col++)
            {
                if (this.grid[currentRow, col] == this.boardColor)
                    return false;
            }
            if (rowsCompleted > 0)
            {
                this.Score += rowsCompleted + 50;
            }
            return true;
        }

        private void removeRow(int removedRow)
        {
            for (int row = removedRow; row > 0; row--)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (row - 1 <= 0)
                        this.grid[row, col] = this.boardColor;
                    else
                        this.grid[row, col] = this.grid[row - 1, col];
                }
            }
        }

        private void colorCodeBoard()
        {
            this.boardColor = Convert.ToInt32("000000", 16);
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    grid[i, j] = this.boardColor;
                }
            }
        }

    }
}
