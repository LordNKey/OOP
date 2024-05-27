using OOP_C_.Figures.Inharitance_Rectangle.Ellipses.Inharitance_Oval;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Triangles
{
    internal class Rectangular_Triangle_Factory : Figure_Factory
    {
        public override string name { get => "Прямоугольный треугольник"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Rectangular_Triangle(fill_color_, border_color_, start_point, last_point);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            // Create rectangular_triangle. Creating in realative to the highest left point of the rectangle
            PointF[] rectangular_triangle = {new PointF(figure.top_corner_point.X, figure.lower_corner_point.Y),
                                             figure.top_corner_point,
                                             figure.lower_corner_point};
            // Draw triangle
            g.FillPolygon(new SolidBrush(figure.fill_color), rectangular_triangle);
            g.DrawPolygon(new Pen(figure.border_color, figure.border_width), rectangular_triangle);
        }
        public override bool Contains(Figure figure, PointF point_click)
        {
            PointF[] rectangular_triangle = {new PointF(figure.top_corner_point.X, figure.lower_corner_point.Y),
                                             figure.top_corner_point,
                                             figure.lower_corner_point};

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(rectangular_triangle);
            return path.IsVisible(point_click);
        }
    }
}
