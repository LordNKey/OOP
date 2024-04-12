using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Circle : Figure
    {
        protected float radius;
        public Circle(Color fill_color_, Color out_color_, float coordinate_x_, float coordinate_y_, float radius_)
        {
            fill_color = fill_color_;
            out_color = out_color_;
            coordinate_x = coordinate_x_;
            coordinate_y = coordinate_y_;
            radius = radius_;
        }
        override public void Draw(Graphics g)
        {
            RectangleF rect = new RectangleF(coordinate_x - radius, coordinate_y - radius, radius*2, radius*2);
            g.FillEllipse(new SolidBrush(fill_color), rect);
            g.DrawEllipse(new Pen(out_color, border_width), rect);
        }
    }
}
