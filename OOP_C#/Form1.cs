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
            List_Figures.Draw_Figures(graphic);
        }


        Color fill_color;
        Color border_color;
        PointF first_point;
        bool Set = false;
        private void pbMainField_MouseDown(object sender, MouseEventArgs e)
        {
            int index = cbFigure.SelectedIndex;
            if (!Set)
            {
                Set = true;
                first_point = e.Location;
                List_Figures.Add_Figure(List_Concrete_Factories.factories[index].Create_Figure(fill_color, border_color, first_point, first_point), index);
            }
        }

        private void pbMainField_MouseMove(object sender, MouseEventArgs e)
        {
            if (Set)
            {
                List_Figures.Last().figure.Change_Params(first_point.X - e.X, first_point.Y - e.Y);
                pbMainField.Invalidate();
                pbMainField.Update();
            }
        }

        private void bFill_color_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();
            Dialog.AllowFullOpen = true;
            Dialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            Dialog.Color = bFill_color.BackColor;

            // Update the text box color if the user clicks OK  
            if (Dialog.ShowDialog() == DialogResult.OK)
                bFill_color.BackColor = fill_color = Dialog.Color;
        }

        private void bBorder_color_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();
            Dialog.AllowFullOpen = true;
            Dialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            Dialog.Color = bBorder_color.BackColor;

            // Update the text box color if the user clicks OK  
            if (Dialog.ShowDialog() == DialogResult.OK)
                bBorder_color.BackColor = border_color = Dialog.Color;
        }

        private void pbMainField_MouseUp(object sender, MouseEventArgs e)
        {
            if (Set)
            {
                Set = false;
            }
        }
    }
}
