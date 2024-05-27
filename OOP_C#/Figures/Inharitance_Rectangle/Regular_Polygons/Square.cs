using OOP_C_.Figures.Inharitance_Rectangle.Ellipses.Inharitance_Oval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Regular_Polygons
{
    internal class Square : Circle
    {
        public Square(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point) :
            base(fill_color_, border_color_, top_corner_point, lower_corner_point)
        { }
    }
}
