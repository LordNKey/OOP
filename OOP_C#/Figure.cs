using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    internal class Figure
    {
        protected Color fill_color;
        protected Color out_color;
        protected float border_width = 3;
        //field; coordinate;
        protected float coordinate_x;
        protected float coordinate_y;
        public virtual void Draw(Graphics g) { }
    }

    internal class List_Figures
    {
        private static List<Figure> figures = new List<Figure>();
        public void Add_Figure(Figure figure)
        {
            figures.Add(figure);
        }
        public void Draw_Figures(Graphics g)
        {
            foreach (Figure figure in figures) 
            {
                figure.Draw(g);
            }
        }
    }
}
