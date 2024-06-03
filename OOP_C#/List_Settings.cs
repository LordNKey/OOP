using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    internal class List_Settings
    {

        public List<File_DLL> settingsList;

        public List_Settings() {
            this.settingsList = new List<File_DLL>();
        }
        public string PostSave(string preSave)
        {
            string res = "";
            foreach (var file_dll in settingsList)
            {
                if (file_dll.set == true)
                {
                    if (res != "")
                    {
                        res = file_dll.PostSave(res);
                    }
                    else
                    {
                        res = file_dll.PostSave(preSave);
                    }
                }
            }
            if (res == "")
            {
                res = preSave;
            }
            return res;
        }

        public string PreOpen(string fileData)
        {
            string res = "";
            foreach (var file_dll in settingsList)
            {
                if (file_dll.set == true)
                {
                    if (res != "")
                    {
                        res = file_dll.PreOpen(res);
                    }
                    else
                    {
                        res = file_dll.PreOpen(fileData);
                    }
                }
            }
            if(res == "")
            {
                res = fileData;
            }
            return res;
        }

        public void LoadAll()
        {
            // Getting the base path to the project (project folder)
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            // Path to the folder with DLL
            string fileDllDirectory = Path.Combine(projectDirectory, "Functional DLLS");

            if (Directory.Exists(fileDllDirectory))
            {
                // Search for all DLL files in the folder
                string[] dllFiles = Directory.GetFiles(fileDllDirectory, "*.dll");

                foreach (string dllFile in dllFiles)
                {
                    try
                    {
                        // Work with DLL
                        Assembly assemblyDll = Assembly.LoadFrom(dllFile);

                        Type[] typesDll = assemblyDll.GetTypes();

                        // Functional DLLS
                        List<Type> file_dlls = typesDll.Where(t => t.IsSubclassOf(typeof(File_DLL))).ToList();
                        foreach (var type in file_dlls)
                        {
                            if (!type.IsAbstract)
                            {
                                settingsList.Add(Activator.CreateInstance(type) as File_DLL);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
