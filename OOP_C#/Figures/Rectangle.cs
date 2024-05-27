using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures
{
    internal class Rectangle : Figure
    {
        public Rectangle(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point) :
            base(fill_color_, border_color_, top_corner_point, lower_corner_point)
        { }

        public override void Change_Params_Create(PointF start_point, PointF last_point)
        {
            this.lower_corner_point = last_point;
        }
    }
}
