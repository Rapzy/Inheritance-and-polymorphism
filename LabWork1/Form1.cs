using System.Drawing;
using System.Windows.Forms;

namespace LabWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {  
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics graph = Graphics.FromImage(bmp);
            FigureList Figures = new FigureList();
            Figures.Add(new Line(new Pen(Color.Red), 100, 100, 200, 200));
            Figures.Add(new Triangle(new Pen(Color.Blue), 250, 200, 300, 50, 350, 200));
            Figures.Add(new Rectangle(new Pen(Color.Black), 300, 300, 100, 200));
            Figures.Add(new Ellipse(new Pen(Color.Purple), 300, 300, 100, 200));
            Figures.Add(new Square(new Pen(Color.Green), 450, 300, 100));
            Figures.Add(new Circle(new Pen(Color.Brown), 450, 300, 100));
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graph);
            }
            this.BackgroundImage = bmp;
        }
    }
}
