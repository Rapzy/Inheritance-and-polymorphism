using System.Drawing;

namespace LabWork1
{
    class Figure
    {
        public Pen pen { get; set; }
        public virtual void Draw(Graphics graph) {}
    }
}
