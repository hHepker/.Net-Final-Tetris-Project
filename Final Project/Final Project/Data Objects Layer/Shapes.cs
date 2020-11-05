using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace Data_Objects_Layer
{

   public class Shape
    {

        public int x { get; set; }
        public int y { get; set; }
        public int shapesColor { get; set; }
        public bool[,] currShape;
        public List<Shape> ShapeBlocks;
        public ShapesName shapesName;
        private Shape shape;
        private Color color;
        private int[] Colors;
        public static int ShapeLength { get { return ShapeLength; } }
        Random random = new Random();
        private static readonly int Count;
        public Point Location { get; set; }

        public Shape(Point location, Color color)
        {
            this.defineShapes();
            //this.Colors = GetColors();
            this.getNextShape();
            this.ShapeBlocks = new List<Shape>();
            this.Location = location;
        }

        public void Draw(Graphics g)
        {
            foreach (Shape shapes in ShapeBlocks)
                shapes.Draw(g);
        }

        public void getNextShape()
        {
            int randomBlock = random.Next(7);
            int startPosition = random.Next(6);
            this.x = startPosition;
            this.y = 0;
            this.shapesColor = this.Colors[randomBlock];
        }

        public Coordinate toBoardCoord(Coordinate coordinate)
        {
            coordinate.x += this.x;
            coordinate.y += this.y;
            return coordinate;
        }

        public Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

        private void defineShapes()
        {
            this.shape = shape;
            GetColors();
        }

        public enum ShapesName
        {
            E,
            I,
            L,
            Z,
            S,
            O,
            T
        }

        private Color GetColors()
        {

            switch (shape.shapesName)
            {
                case ShapesName.E:
                    _ = Color.White;
                    break;
                case ShapesName.I:
                    _ = Color.Blue;
                    break;
                case ShapesName.L:
                    _ = Color.Orange;
                    break;
                case ShapesName.Z:
                    _ = Color.Yellow;
                    break;
                case ShapesName.S:
                    _ = Color.Green;
                    break;
                case ShapesName.O:
                    _ = Color.Purple;
                    break;
                case ShapesName.T:
                    _ = Color.Red;
                    break;
                default:
                    break;
            }
        }

        public void Moves(Direction direction, int distance) 
        {
            Move(direction, Shape.ShapeLength);
            switch (direction)
            {
                case (Direction.Left):
                    MoveShapeLeft(distance);
                    break;
                case (Direction.Right):
                    MoveShapeRight(distance);
                    break;
                default:
                    break;
            }
        }

        public void MoveShapeLeft(int distance)
        {
            for (int i = 0; i < Shape.Count; i++)
                ShapeBlocks[i].Move(Direction.Left, distance);
        }

        public void MoveShapeRight(int distance)
        {
            for (int i = 0; i < Shape.Count; i++)
                ShapeBlocks[i].Move(Direction.Right, distance);
        }

        public void Move(Direction directionToMove, int distanceToMove)
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
        public enum Direction
        {
            Right,
            Left
        }
    }
}
