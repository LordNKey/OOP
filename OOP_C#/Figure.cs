using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    internal class Figure
    {
        public Color fill_color;
        public Color border_color;
        public float border_width = 3;
        //field; coordinate;
        public float coordinate_x;
        public float coordinate_y;
        public virtual void Draw(Graphics g) { }
        //public virtual void Change_Params(PointF point_1, PointF point_2)
        public virtual void Change_Params(float dist_x, float dist_y) { }
    }

    internal static class List_Figures
    {
        public struct Figure_Factory
        {
            public Figure_Factory(Figure figure, int num_concrete_factory) 
            {
                this.figure = figure;
                this.num_concrete_factory = num_concrete_factory;
            }
            public Figure figure;
            public int num_concrete_factory;
        }
        private static List<Figure_Factory> figures = new List<Figure_Factory>();
        public static void Add_Figure(Figure figure, int num_concrete_factory)
        {
            figures.Add(new Figure_Factory(figure, num_concrete_factory));
        }
        public static void Draw_Figures(Graphics g)
        {
            foreach (var figure in figures)
            {
                List_Concrete_Factories.factories[figure.num_concrete_factory].Draw(figure.figure, g);
            }
        }
        public static Figure_Factory Last()
        {
            return figures.Last();
        }
    }
}
