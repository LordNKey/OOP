using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Square_Factory : Figure_Factory
    {
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF point_1, PointF point_2)
        {
            return new Square(fill_color_, border_color_, point_1.X, point_1.Y, (float)Math.Sqrt((point_1.X - point_2.X) * (point_1.X - point_2.X) +
                                                                                                 (point_1.Y - point_2.Y) * (point_1.Y - point_2.Y)));
        }
        public override void Draw(Figure figure, Graphics g)
        {
            RectangleF rect = new RectangleF(figure.coordinate_x - ((Square)figure).width / 2, figure.coordinate_y - ((Square)figure).width / 2, ((Square)figure).width, ((Square)figure).width);
            g.FillRectangle(new SolidBrush(figure.fill_color), rect);
            g.DrawRectangle(new Pen(figure.border_color, figure.border_width), rect);
        }
    }
}
