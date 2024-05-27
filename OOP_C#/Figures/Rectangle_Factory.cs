using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Rectangle_Factory : Figure_Factory
    {
        public override string name { get => "Прямоугольник"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Rectangle(fill_color_, border_color_, start_point, last_point);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            RectangleF rect = Right_Rectangle(figure.top_corner_point, figure.lower_corner_point);
            g.FillRectangle(new SolidBrush(figure.fill_color), rect);
            g.DrawRectangle(new Pen(figure.border_color, figure.border_width), rect);
        }
    }
}
