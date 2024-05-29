using OOP_C_;
using OOP_C_.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Pentagon
{
    public class Pentagon_Factory : Rectangle_Factory
    {
        public override string name { get => "Пятиугольник"; }
        public override Figure Create_Figure(Color fill_color_, Color border_color_, PointF start_point, PointF last_point)
        {
            return new Pentagon(fill_color_, border_color_, start_point, last_point);
        }
        public override void Draw(Figure figure, Graphics g)
        {
            float firstPairY = figure.top_corner_point.Y - (figure.top_corner_point.Y - figure.lower_corner_point.Y) * 3 / 8;
            float secondPairXSym = (figure.lower_corner_point.X - figure.top_corner_point.X) * 1 / 8;
            PointF[] pentagon = {new PointF((figure.top_corner_point.X + figure.lower_corner_point.X) / 2, figure.top_corner_point.Y),

                                 new PointF(figure.top_corner_point.X, firstPairY),
                                 new PointF(figure.top_corner_point.X + secondPairXSym, figure.lower_corner_point.Y),

                                 new PointF(figure.lower_corner_point.X - secondPairXSym, figure.lower_corner_point.Y),
                                 new PointF(figure.lower_corner_point.X, firstPairY)};

            g.FillPolygon(new SolidBrush(figure.fill_color), pentagon);
            g.DrawPolygon(new Pen(figure.border_color, figure.border_width), pentagon);
        }

        public override bool Contains(Figure figure, PointF point_click)
        {
            float firstPairY = figure.top_corner_point.Y + (figure.top_corner_point.Y - figure.lower_corner_point.Y) * 3 / 8;
            float secondPairXSym = (figure.top_corner_point.X - figure.lower_corner_point.X) * 1 / 8;
            PointF[] pentagon = {new PointF((figure.top_corner_point.X + figure.lower_corner_point.X) / 2, figure.top_corner_point.Y),

                                 new PointF(figure.top_corner_point.X, firstPairY),
                                 new PointF(figure.top_corner_point.X + secondPairXSym, figure.lower_corner_point.Y),

                                 new PointF(figure.lower_corner_point.X - secondPairXSym, figure.lower_corner_point.Y),
                                 new PointF(figure.lower_corner_point.X, firstPairY)};

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(pentagon);
            return path.IsVisible(point_click);
        }
    }
}
