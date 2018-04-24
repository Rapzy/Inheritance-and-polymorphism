using System.Drawing;

namespace LabWork1
{
    class Square:Figure
    {
        public int x1, y1, width;
        public Square(Pen pen, int x1, int y1, int width)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.pen = pen;
        }
        public override void Draw(Graphics graph)
        {
            graph.DrawRectangle(pen, x1, y1, width, width);
        }
    }
}
