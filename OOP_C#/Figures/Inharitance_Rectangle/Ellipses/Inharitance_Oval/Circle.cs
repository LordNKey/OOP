using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Ellipses.Inharitance_Oval
{
    internal class Circle : Oval
    {
        public Circle(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point) :
            base(fill_color_, border_color_, top_corner_point, lower_corner_point)
        { }
        public override void Change_Params_Create(PointF start_point, PointF last_point)
        {
            float dist_x = last_point.X - start_point.X;
            float dist_y = last_point.Y - start_point.Y;
            float distance = (float)Math.Sqrt(dist_x * dist_x + dist_y * dist_y);
            this.top_corner_point = new PointF(start_point.X - distance, start_point.Y - distance);
            this.lower_corner_point = new PointF(start_point.X + distance, start_point.Y + distance);
        }
        /*public override void Change_Params(float dist_x, float dist_y)
        {
            radius = (float)Math.Sqrt(dist_x * dist_x + dist_y * dist_y);
        }*/
    }
}
