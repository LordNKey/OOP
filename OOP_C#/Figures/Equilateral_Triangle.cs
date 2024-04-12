using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Equilateral_Triangle : Figure
    {
        protected float radius;
        public Equilateral_Triangle(Color fill_color_, Color out_color_, float coordinate_x_, float coordinate_y_, float radius_)
        {
            fill_color = fill_color_;
            out_color = out_color_;
            coordinate_x = coordinate_x_;
            coordinate_y = coordinate_y_;
            radius = radius_;
        }
        override public void Draw(Graphics g)
        {
            float inscribed_radius = radius / 2;
            float half_side = (float)(radius / 2 * Math.Sqrt(3.0));

            // Create equilateral_triangle. Creating in realative to the center of the circum/inscribed circle
            PointF[] equilateral_triangle = {new PointF(coordinate_x - half_side, coordinate_y + inscribed_radius),
                                             new PointF(coordinate_x, coordinate_y - radius),
                                             new PointF(coordinate_x + half_side, coordinate_y + inscribed_radius)};
            // Draw triangle
            g.FillPolygon(new SolidBrush(fill_color), equilateral_triangle);
            g.DrawPolygon(new Pen(out_color, border_width), equilateral_triangle);
        }
    }
}
