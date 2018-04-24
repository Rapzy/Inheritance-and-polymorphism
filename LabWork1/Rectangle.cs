using System.Drawing;

namespace LabWork1
{
    class Rectangle:Figure
    {
        public int x1, y1, width, height;
        public Rectangle(Pen pen, int x1, int y1, int width, int height)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            this.pen = pen;
        }
        public override void Draw(Graphics graph)
        {
            graph.DrawRectangle(pen, x1, y1, width, height);
        }
    }
}
