using System.Drawing;

namespace LabWork1
{
    class Triangle:Line
    {
        public int x3 { get; set; }
        public int y3 { get; set; }
        public Triangle(Pen pen, int x1, int y1, int x2, int y2, int x3, int y3):base(pen,x1,y1,x2,y2)
        {
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawLine(pen, x1, y1, x2, y2);
            graph.DrawLine(pen, x2, y2, x3, y3);
            graph.DrawLine(pen, x1, y1, x3, y3);
        }
    }
}
