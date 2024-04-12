using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle
{
    internal class Oval : Rectangle
    {
        public Oval(Color fill_color_, Color out_color_, float coordinate_x_, float coordinate_y_, float width_, float height_) :
            base(fill_color_, out_color_, coordinate_x_, coordinate_y_, width_, height_){ }
        override public void Draw(Graphics g)
        {
            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(coordinate_x, coordinate_y, width, height);
            g.FillEllipse(new SolidBrush(fill_color), rect);
            g.DrawEllipse(new Pen(out_color, border_width), rect);
        }
    }
}
