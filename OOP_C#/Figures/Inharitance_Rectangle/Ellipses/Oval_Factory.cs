using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_.Figures.Inharitance_Rectangle.Ellipses
{
    internal class Oval_Factory : Figure_Factory
    {
        public override string name { get => "Овал"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Oval(fill_color_, border_color_, start_point, last_point);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            RectangleF rect = Right_Rectangle(figure.top_corner_point, figure.lower_corner_point);
            g.FillEllipse(new SolidBrush(figure.fill_color), rect);
            g.DrawEllipse(new Pen(figure.border_color, figure.border_width), rect);
        }
        public override bool Contains(Figure figure, PointF point_click)
        {
            RectangleF rect = Right_Rectangle(figure.top_corner_point, figure.lower_corner_point);
            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            return path.IsVisible(point_click);
        }
    }
}
