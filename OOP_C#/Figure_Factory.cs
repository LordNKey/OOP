using OOP_C_.Figures;
using OOP_C_.Figures.Inharitance_Square;
using OOP_C_.Figures.Inharitance_Square.Inharitance_Rectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    internal abstract class Figure_Factory
    {
        public abstract Figure Create_Figure(Color fill_color, Color border_color, PointF point_1, PointF point_2);
        public abstract void Draw(Figure figure, Graphics g);
        /*public void Draw_Figure(Graphics g)
        {
            Figure figure = Create_Figure();
            Draw(figure, g);
        }*/

        internal static RectangleF Right_Rectangle(float coordinate_x, float coordinate_y, float width, float height)
        {
            if (width < 0)
            {
                if (height < 0)
                {
                    return new System.Drawing.RectangleF(coordinate_x, coordinate_y, -width, -height);
                }
                else
                {
                    return new System.Drawing.RectangleF(coordinate_x, coordinate_y - height, -width, height);
                }
            }
            else
            {
                if (height < 0)
                {
                    return new System.Drawing.RectangleF(coordinate_x - width, coordinate_y, width, -height);
                }
                else
                {
                    return new System.Drawing.RectangleF(coordinate_x - width, coordinate_y - height, width, height);
                }
            }
        }
    }

    internal static class List_Concrete_Factories
    {
        public static Figure_Factory[] factories = {new Square_Factory(),
                                                    new Rectangle_Factory(),
                                                    new Circle_Factory(),
                                                    new Oval_Factory(),
                                                    new Equilateral_Triangle_Factory(),
                                                    new Isosceles_Triangle_Factory(),
                                                    new Rectangular_Triangle_Factory()};
        /*public static List<Figure_Factory> factories = new List<Figure_Factory>(new() { new Square_Factory(),
                                                    new Rectangle_Factory(),
                                                    new Circle_Factory(),
                                                    new Oval_Factory(),
                                                    new Equilateral_Triangle_Factory(),
                                                    new Isosceles_Triangle_Factory(),
                                                    new Rectangular_Triangle_Factory()});*/
    }
}
