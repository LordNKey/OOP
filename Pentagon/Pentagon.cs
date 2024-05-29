using OOP_C_;
using OOP_C_.Figures;
using System.Drawing;

namespace Pentagon
{
    public class Pentagon : OOP_C_.Figures.Rectangle
    {
        public Pentagon(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point) :
            base(fill_color_, border_color_, top_corner_point, lower_corner_point)
        { }
    }
}
