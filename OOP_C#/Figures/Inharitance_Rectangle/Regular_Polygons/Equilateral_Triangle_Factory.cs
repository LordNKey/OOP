using OOP_C_.Figures.Inharitance_Rectangle.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Regular_Polygons
{
    internal class Equilateral_Triangle_Factory : Isosceles_Triangle_Factory
    {
        public override string name { get => "Равносторонний треугольник"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Equilateral_Triangle(fill_color_, border_color_, start_point, last_point);
        }
    }
}
