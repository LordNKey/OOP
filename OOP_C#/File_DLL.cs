using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    public abstract class File_DLL
    {
        public bool set { get; set; } = false;
        public virtual string settingItem { get => "Пункт настроек"; }
        public abstract string PostSave(string preSave);
        public abstract string PreOpen(string fileData);
    }
}
