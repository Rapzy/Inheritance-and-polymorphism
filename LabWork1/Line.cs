using System.Drawing;

namespace LabWork1
{
    class Line:Figure
    {
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Line(Pen pen,int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.pen = pen;
        }
        public override void Draw(Graphics graph)
        {
            graph.DrawLine(pen,x1, y1, x2, y2);
        }
    }
}
