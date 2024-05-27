using OOP_C_.Figures;
using OOP_C_.Figures.Inharitance_Rectangle.Ellipses;
using OOP_C_.Figures.Inharitance_Rectangle.Ellipses.Inharitance_Oval;
using OOP_C_.Figures.Inharitance_Rectangle.Regular_Polygons;
using OOP_C_.Figures.Inharitance_Rectangle.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP_C_
{
    internal abstract class Figure_Factory
    {
        public virtual string name { get => "Figure"; }
        //protected string name = "Figure"; 

        public abstract Figure Create_Figure(Color fill_color, Color border_color, PointF point_1, PointF point_2);
        public abstract void Draw(Figure figure, Graphics g);
        /*public void Draw_Figure(Graphics g)
        {
            Figure figure = Create_Figure();
            Draw(figure, g);
        }*/

        internal static RectangleF Right_Rectangle(PointF top_corner_point, PointF lower_corner_point)
        {
            float width = lower_corner_point.X - top_corner_point.X;
            float height = lower_corner_point.Y - top_corner_point.Y;
            if (width < 0)
            {
                if (height < 0)
                {
                    return new System.Drawing.RectangleF(lower_corner_point.X, lower_corner_point.Y, -width, -height);
                }
                else
                {
                    return new System.Drawing.RectangleF(lower_corner_point.X, top_corner_point.Y, -width, height);
                }
            }
            else
            {
                if (height < 0)
                {
                    return new System.Drawing.RectangleF(top_corner_point.X, lower_corner_point.Y, width, -height);
                }
                else
                {
                    return new System.Drawing.RectangleF(top_corner_point.X, top_corner_point.Y, width, height);
                }
            }
        }

        public void Draw_Border(Figure figure, Graphics g)
        {
            if (figure.selected)
            {
                RectangleF rect = Right_Rectangle(figure.top_corner_point, figure.lower_corner_point);
                Pen pen = new Pen(Color.Black, 5);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, rect);
            }
        }
        public virtual bool Contains(Figure figure, PointF point_click)
        {
            RectangleF rect = Right_Rectangle(figure.top_corner_point, figure.lower_corner_point);
            return rect.Contains(point_click);
        }
    }

    internal static class List_Concrete_Factories
    {
        public static List<Figure_Factory> factories = new List<Figure_Factory>();

        public static void Initialize()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            List<Type> tempList = types.Where(t => t.IsSubclassOf(typeof(Figure_Factory))).ToList();
            foreach (var type in tempList)
            {
                if (!type.IsAbstract)
                {
                    factories.Add(Activator.CreateInstance(type) as Figure_Factory);
                }
            }
        }

        /*public static List<Figure_Factory> factories = new List<Figure_Factory>(new() { new Square_Factory(),
                                                    new Rectangle_Factory(),
                                                    new Circle_Factory(),
                                                    new Oval_Factory(),
                                                    new Equilateral_Triangle_Factory(),
                                                    new Isosceles_Triangle_Factory(),
                                                    new Rectangular_Triangle_Factory()});*/
    }
}
