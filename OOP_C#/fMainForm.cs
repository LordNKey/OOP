using OOP_C_.Figures;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using static OOP_C_.List_Settings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OOP_C_
{
    public partial class fMainForm : Form
    {
        internal List_Settings listSettings; 
        public fMainForm()
        {
            InitializeComponent();
            List_Concrete_Factories.Initialize();
            foreach (Figure_Factory factory in List_Concrete_Factories.factories)
            {
                cbFigure.Items.Add(factory.name);
            }


            listSettings = new List_Settings();
            listSettings.LoadAll();
            ToolStripMenuItem settings = (ToolStripMenuItem)msMainMenu.Items.Find("íàñòðîéêèToolStripMenuItem", false)[0];
            for (int i = 0; i < listSettings.settingsList.Count; i++)
            {
                File_DLL setting = listSettings.settingsList[i];

                // Menu Subitem
                ToolStripMenuItem newSubMenuItem = new ToolStripMenuItem(setting.settingItem)
                {
                    Checked = false,
                    CheckOnClick = true
                };

                // Event Click
                newSubMenuItem.CheckedChanged += delegate (object sender, EventArgs e)
                {
                    setting.set = !setting.set;
                };

                // Add Subitem
                settings.DropDownItems.Add(newSubMenuItem);
            }
        }


        private void pbMainField_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            List_Figures.Draw_Figures(graphic);
        }

        Color fill_color;
        Color border_color;
        PointF first_point;
        bool create = false;
        bool change = false;
        List<Figure> change_figure = new List<Figure>();
        private void pbMainField_MouseDown(object sender, MouseEventArgs e)
        {
            Figure tmp;
            if ((tmp = List_Figures.Search_Figure(e.Location)) != null)
            {
                change_figure.Add(tmp);
                change = true;
                bFill_color.BackColor = fill_color = change_figure.Last().fill_color;
                bBorder_color.BackColor = border_color = change_figure.Last().border_color;
            }
            else
            {
                // Reset selection
                foreach (Figure figure in change_figure)
                {
                    figure.selected = false;
                    change_figure = new List<Figure>();
                }
                // Create new figure
                int index = cbFigure.SelectedIndex;
                if (!create)
                {
                    create = true;
                    first_point = e.Location;
                    List_Figures.Add_Figure(List_Concrete_Factories.factories[index].Create_Figure(fill_color, border_color, first_point, first_point), index);
                }
            }
            pbMainField.Invalidate();
            pbMainField.Update();
        }

        private void pbMainField_MouseMove(object sender, MouseEventArgs e)
        {
            if (create)
            {
                List_Figures.Last().figure.Change_Params_Create(first_point, e.Location);
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
            {
                if (change)
                {
                    bFill_color.BackColor = fill_color = Dialog.Color;
                    foreach (Figure figure in change_figure)
                    {
                        figure.fill_color = fill_color;
                    }
                }
                else
                {
                    bFill_color.BackColor = fill_color = Dialog.Color;
                }
            }
            pbMainField.Invalidate();
            pbMainField.Update();
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
            {
                if (change)
                {
                    bBorder_color.BackColor = border_color = Dialog.Color;
                    foreach (Figure figure in change_figure)
                    {
                        figure.border_color = border_color;
                    }
                }
                else
                {
                    bBorder_color.BackColor = border_color = Dialog.Color;
                }
            }
            pbMainField.Invalidate();
            pbMainField.Update();
        }

        private void pbMainField_MouseUp(object sender, MouseEventArgs e)
        {
            if (create)
            {
                create = false;
            }
        }

        ///////////////////////
        /// Deserialisation ///
        ///////////////////////
        private void jSONToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                OpenFile.InitialDirectory = "d:\\OOP";
                OpenFile.RestoreDirectory = true;

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(OpenFile.FileName);
                    List_Figures.Unserialisation_JSON(listSettings.PreOpen(json));
                }
            }
            pbMainField.Invalidate();
            pbMainField.Update();
        }

        private void bINToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFile = new OpenFileDialog())
            {
                OpenFile.InitialDirectory = "d:\\OOP";
                OpenFile.RestoreDirectory = true;

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string fileData = File.ReadAllText(OpenFile.FileName, Encoding.GetEncoding("iso-8859-1"));
                    File.WriteAllText(OpenFile.FileName, listSettings.PreOpen(fileData));
                    using (var stream = File.Open(OpenFile.FileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            List_Figures.Unserialisation_BIN(reader);
                        }
                    }
                    //File.WriteAllBytes(SaveFile.FileName, Bytes);
                }
            }
            pbMainField.Invalidate();
            pbMainField.Update();
        }

        /////////////////////
        /// Serialisation ///
        /////////////////////
        private void jSONToolStripMenuSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SaveFile = new SaveFileDialog())
            {
                SaveFile.InitialDirectory = "d:\\OOP";
                SaveFile.RestoreDirectory = true;

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    string preSave = List_Figures.Serialisation_JSON();
                    File.WriteAllText(SaveFile.FileName, listSettings.PostSave(preSave));
                }
            }
        }

        private void bINToolStripMenuSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SaveFile = new SaveFileDialog())
            {
                SaveFile.InitialDirectory = "d:\\OOP";
                SaveFile.RestoreDirectory = true;

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(SaveFile.FileName, FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                        {
                            
                            List_Figures.Serialisation_BIN(writer);
                        }
                    }
                    string preSave = File.ReadAllText(SaveFile.FileName, Encoding.UTF8);
                    File.WriteAllText(SaveFile.FileName, listSettings.PostSave(preSave));
                    //File.WriteAllBytes(SaveFile.FileName, Bytes);
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            List<Figure> figures_to_remove = new List<Figure>();
            // Find
            foreach (Figure figure in change_figure)
            {
                List_Figures.Delete_Figure(figure);
                figures_to_remove.Add(figure);

            }
            // Delete
            foreach (Figure figure in figures_to_remove)
            {
                change_figure.Remove(figure);
            }

            pbMainField.Invalidate();
            pbMainField.Update();
        }
    }
}
