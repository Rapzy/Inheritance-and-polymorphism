using System.Drawing;

namespace LabWork1
{
    class Circle:Square
    {
        public Circle(Pen pen, int x1, int y1, int width) : base(pen, x1, y1, width) { }
        public override void Draw(Graphics graph)
        {
            graph.DrawEllipse(pen, x1, y1, width, width);
        }
    }
}
