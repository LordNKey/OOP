using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Ellipses
{
    internal class Oval : Rectangle
    {
        public Oval(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point) :
            base(fill_color_, border_color_, top_corner_point, lower_corner_point)
        { }
    }
}
