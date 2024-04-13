using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Equilateral_Triangle_Factory : Figure_Factory
    {
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF point_1, PointF point_2)
        {
            return new Equilateral_Triangle(fill_color_, border_color_, point_1.X, point_1.Y, (float)Math.Sqrt((point_1.X - point_2.X) * (point_1.X - point_2.X) +
                                                                                                               (point_1.Y - point_2.Y) * (point_1.Y - point_2.Y)));
        }
        public override void Draw(Figure figure, Graphics g)
        {
            float inscribed_radius = ((Equilateral_Triangle)figure).radius / 2;
            float half_side = (float)(((Equilateral_Triangle)figure).radius / 2 * Math.Sqrt(3.0));

            // Create equilateral_triangle. Creating in realative to the center of the circum/inscribed circle
            PointF[] equilateral_triangle = {new PointF(figure.coordinate_x - half_side, figure.coordinate_y + inscribed_radius),
                                             new PointF(figure.coordinate_x, figure.coordinate_y - ((Equilateral_Triangle)figure).radius),
                                             new PointF(figure.coordinate_x + half_side, figure.coordinate_y + inscribed_radius)};
            // Draw triangle
            g.FillPolygon(new SolidBrush(figure.fill_color), equilateral_triangle);
            g.DrawPolygon(new Pen(figure.border_color, figure.border_width), equilateral_triangle);
        }
    }
}
