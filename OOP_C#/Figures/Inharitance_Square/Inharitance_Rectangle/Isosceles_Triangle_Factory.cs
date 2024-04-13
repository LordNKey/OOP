using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle
{
    internal class Isosceles_Triangle_Factory : Figure_Factory
    {
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF point_1, PointF point_2)
        {
            return new Isosceles_Triangle(fill_color_, border_color_, point_1.X, point_1.Y, point_1.X - point_2.X, point_1.Y - point_2.Y);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            // Create isosceles_triangle. Creating in realative to the highest left point of the rectangle
            PointF[] isosceles_triangle = {new PointF(figure.coordinate_x, figure.coordinate_y - ((Isosceles_Triangle)figure).height),
                                             new PointF(figure.coordinate_x - ((Isosceles_Triangle)figure).width / 2, figure.coordinate_y),
                                             new PointF(figure.coordinate_x - ((Isosceles_Triangle)figure).width, figure.coordinate_y - ((Isosceles_Triangle)figure).height)};
            // Draw triangle
            g.FillPolygon(new SolidBrush(figure.fill_color), isosceles_triangle);
            g.DrawPolygon(new Pen(figure.border_color, figure.border_width), isosceles_triangle);
        }
    }
}
