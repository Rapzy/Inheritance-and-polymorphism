using System.Drawing;

namespace LabWork1
{
    class Ellipse:Rectangle
    {
        public Ellipse(Pen pen, int x1, int y1, int width, int height):base(pen,x1,y1,width,height){}
        public override void Draw(Graphics graph)
        {
            graph.DrawEllipse(pen, x1, y1, width, height);
        }
    }
}
