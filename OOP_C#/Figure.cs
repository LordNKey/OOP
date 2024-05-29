using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
//using System.Text;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
using Formatting = Newtonsoft.Json.Formatting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace OOP_C_
{
    public class Figure
    {
        public Figure(Color fill_color_, Color border_color_, PointF top_corner_point, PointF lower_corner_point)
        {
            this.fill_color = fill_color_;
            this.border_color = border_color_;
            this.top_corner_point = top_corner_point;
            this.lower_corner_point = lower_corner_point;
        }

        public Color fill_color;
        public Color border_color;
        public float border_width = 3;
        //field; coordinate;
        public PointF top_corner_point, lower_corner_point;
        //public PointF center_point;
        public bool selected = false;
        //public virtual void Draw(Graphics g) { }
        //public virtual void Change_Params(PointF point_1, PointF point_2)
        public virtual void Change_Params_Create(PointF start_point, PointF last_point) { }
        //public virtual void Change_Params(PointF start_point, PointF last_point) { }
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
        public static LinkedList<Figure_Factory> figures = new LinkedList<Figure_Factory>();
        public static void Add_Figure(Figure figure, int num_concrete_factory)
        {
            figures.AddLast(new Figure_Factory(figure, num_concrete_factory));
        }
        public static Figure Search_Figure(PointF point_click)
        {
            for (LinkedListNode<Figure_Factory> figure = figures.Last; figure != null; figure = figure.Previous)
            {
                if (List_Concrete_Factories.factories[figure.Value.num_concrete_factory].Contains(figure.Value.figure, point_click))
                {
                    figure.Value.figure.selected = true;
                    return figure.Value.figure;
                }
            }
            return null;
        }
        public static void Delete_Figure(Figure change_figure)
        {
            if (change_figure != null)
            {
                var figure_node = figures.Last(x => x.figure == change_figure);

                // Если элемент найден, удаляем его
                if (figure_node.figure != null)
                {
                    figures.Remove(figure_node);
                }
            }
        }

        //public static void Initialize_List_Factory()

        public static void Serialisation_BIN(BinaryWriter writer)
        {
            foreach(var figure in figures)
            {
                writer.Write(figure.figure.ToString());
                writer.Write(ColorTranslator.ToWin32(figure.figure.fill_color));    writer.Write(ColorTranslator.ToWin32(figure.figure.border_color));           
                writer.Write(figure.figure.top_corner_point.X);                     writer.Write(figure.figure.top_corner_point.Y);
                writer.Write(figure.figure.lower_corner_point.X);                   writer.Write(figure.figure.lower_corner_point.Y);
                writer.Write(figure.figure.selected);
                writer.Write(figure.figure.border_width);
            }
        }


        public static string Serialisation_JSON()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented, // Устанавливаем отступы для удобочитаемости
                TypeNameHandling = TypeNameHandling.All // Включаем запись информации о типе объекта
            };

            string json = "[";
            foreach (var figure in figures)
            {
                var str = figure.figure.ToString();
                json += JsonConvert.SerializeObject(figure.figure, settings);
                json += ", \n";
            }
            json += "]";
            return json; 
        }

        public static void Unserialisation_BIN(BinaryReader reader)
        {
            //Figure_Factory figure_;
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                string name_figure = reader.ReadString();
                string name_factory = name_figure + "_Factory";

                Figure figure = null;

                Type type_figure = Type.GetType(name_figure);
                if(type_figure == null)
                {
                    // Getting the base path to the project (project folder)
                    string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

                    // Path to the folder with DLL
                    string dllDirectory = Path.Combine(projectDirectory, "DLLS");

                    if (Directory.Exists(dllDirectory))
                    {
                        // Search for all DLL files in the folder
                        string[] dllFiles = Directory.GetFiles(dllDirectory, "*.dll");

                        foreach (string dllFile in dllFiles)
                        {
                            // Work with DLL
                            Assembly assemblyDll = Assembly.LoadFrom(dllFile);
                            Type[] typesDll = assemblyDll.GetTypes();

                            foreach (var type in typesDll)
                            {
                                if (type.ToString() == name_figure)
                                {
                                    type_figure = type;
                                    break;
                                }
                            }
                        }
                    }
                }

                figure = (Figure)Activator.CreateInstance(type_figure, ColorTranslator.FromWin32(reader.ReadInt32()),
                                                          ColorTranslator.FromWin32(reader.ReadInt32()),
                                                          new PointF(reader.ReadSingle(), reader.ReadSingle()),
                                                          new PointF(reader.ReadSingle(), reader.ReadSingle()));

                figure.selected = reader.ReadBoolean();
                figure.border_width = reader.ReadSingle();
                int number = 0;
                foreach (OOP_C_.Figure_Factory figure_factory in List_Concrete_Factories.factories)
                {
                    if (name_factory == figure_factory.ToString())
                    {
                        List_Figures.Add_Figure(figure, number);
                        break;
                    }
                    number++;
                }
            }
        }

        public static void Unserialisation_JSON(string json)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented, // Устанавливаем отступы для удобочитаемости
                TypeNameHandling = TypeNameHandling.All
            };

            List<Figure> figures = JsonConvert.DeserializeObject<List<Figure>>(json, settings);

            foreach(var figure in figures)
            {
                string name_factory = figure.ToString() + "_Factory";
                int number = 0;
                foreach (OOP_C_.Figure_Factory figure_factory in List_Concrete_Factories.factories)
                {
                    if (name_factory == figure_factory.ToString())
                    {
                        List_Figures.Add_Figure((Figure)figure, number);
                        break;
                    }
                    number++;
                }
            }
        }


        public static void Draw_Figures(Graphics g)
        {
            foreach (var figure in figures)
            {
                List_Concrete_Factories.factories[figure.num_concrete_factory].Draw(figure.figure, g);
                List_Concrete_Factories.factories[figure.num_concrete_factory].Draw_Border(figure.figure, g);
            }
        }
        public static Figure_Factory Last()
        {
            return figures.Last();
        }
    }
}
