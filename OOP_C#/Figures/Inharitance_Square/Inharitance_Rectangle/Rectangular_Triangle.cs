using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle
{
    internal class Rectangular_Triangle : Rectangle
    {
        public Rectangular_Triangle(Color fill_color_, Color border_color_, float coordinate_x_, float coordinate_y_, float width_, float height_) : 
            base(fill_color_, border_color_, coordinate_x_, coordinate_y_, width_, height_){}
    }
}
