using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square
{
    internal class Rectangle : Square
    {
        public float height;
        public Rectangle(Color fill_color_, Color border_color_, float coordinate_x_, float coordinate_y_, float width_, float height_) : 
            base(fill_color_, border_color_, coordinate_x_, coordinate_y_, width_)
        {
            height = height_;
        }
        public override void Change_Params(float dist_x, float dist_y)
        {
            width = dist_x;
            height = dist_y;
        }
    }
}
