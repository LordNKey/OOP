using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle
{
    internal class Oval_Factory : Figure_Factory
    {
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF point_1, PointF point_2)
        {
            return new Oval(fill_color_, border_color_, point_1.X, point_1.Y, point_1.X - point_2.X, point_1.Y - point_2.Y);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            System.Drawing.RectangleF rect = Right_Rectangle(figure.coordinate_x, figure.coordinate_y, ((Oval)figure).width, ((Oval)figure).height);
            g.FillEllipse(new SolidBrush(figure.fill_color), rect);
            g.DrawEllipse(new Pen(figure.border_color, figure.border_width), rect);
        }
    }
}
