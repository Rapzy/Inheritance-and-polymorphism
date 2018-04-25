using System.Drawing;

namespace LabWork1
{
     abstract class Figure
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public Pen pen { get; set; }
        public virtual void Draw(Graphics graph) {}
    }
}
