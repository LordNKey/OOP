using OOP_C_.Figures;

namespace OOP_C_
{
    public partial class fMainForm : Form
    {
        public fMainForm()
        {
            InitializeComponent();
        }

        private void pbMainField_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            List_Figures list_Figures = new List_Figures();
            Square square = new Square(Color.Red, Color.Black, 100, 100, 50);
            list_Figures.Add_Figure(square);
            OOP_C_.Figures.Inharitance_Square.Rectangle rec = new OOP_C_.Figures.Inharitance_Square.Rectangle(Color.Red, Color.Aqua, 200, 300, 50, 80);
            list_Figures.Add_Figure(rec);
            list_Figures.Draw_Figures(graphic);
        }
    }
}
