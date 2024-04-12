using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle
{
    internal class Rectangular_Triangle : Rectangle
    {
        public Rectangular_Triangle(Color fill_color_, Color out_color_, float coordinate_x_, float coordinate_y_, float width_, float height_) : 
            base(fill_color_, out_color_, coordinate_x_, coordinate_y_, width_, height_){}
        override public void Draw(Graphics g)
        {
            // Create rectangular_triangle. Creating in realative to the highest left point of the rectangle
            PointF[] rectangular_triangle = {new PointF(coordinate_x, coordinate_y + height),
                                             new PointF(coordinate_x, coordinate_y),
                                             new PointF(coordinate_x + width, coordinate_y + height)};
            // Draw triangle
            g.FillPolygon(new SolidBrush(fill_color), rectangular_triangle);
            g.DrawPolygon(new Pen(out_color, border_width), rectangular_triangle);
        }
    }
}
