using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Equilateral_Triangle : Figure
    {
        public float radius;
        public Equilateral_Triangle(Color fill_color_, Color border_color_, float coordinate_x_, float coordinate_y_, float radius_)
        {
            fill_color = fill_color_;
            border_color = border_color_;
            coordinate_x = coordinate_x_;
            coordinate_y = coordinate_y_;
            radius = radius_;
        }
        public override void Change_Params(float dist_x, float dist_y)
        {
            radius = (float)Math.Sqrt(dist_x * dist_x + dist_y * dist_y);
        }
    }
}
