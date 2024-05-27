using OOP_C_.Figures.Inharitance_Rectangle.Ellipses.Inharitance_Oval;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Triangles
{
    internal class Isosceles_Triangle_Factory : Figure_Factory
    {
        public override string name { get => "Равнобедренный треугольник"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Isosceles_Triangle(fill_color_, border_color_, start_point, last_point);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            // Create isosceles_triangle. Creating in realative to the highest left point of the rectangle
            PointF[] isosceles_triangle = {new PointF(figure.top_corner_point.X, figure.lower_corner_point.Y),
                                           new PointF((figure.top_corner_point.X + figure.lower_corner_point.X) / 2, figure.top_corner_point.Y),
                                           figure.lower_corner_point};
            // Draw triangle
            g.FillPolygon(new SolidBrush(figure.fill_color), isosceles_triangle);
            g.DrawPolygon(new Pen(figure.border_color, figure.border_width), isosceles_triangle);
        }
        public override bool Contains(Figure figure, PointF point_click)
        {
            PointF[] isosceles_triangle = {new PointF(figure.top_corner_point.X, figure.lower_corner_point.Y),
                                           new PointF((figure.top_corner_point.X + figure.lower_corner_point.X) / 2, figure.top_corner_point.Y),
                                           figure.lower_corner_point};

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(isosceles_triangle);
            return path.IsVisible(point_click);
        }
    }
}
