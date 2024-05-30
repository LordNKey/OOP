using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_
{
    public interface File_DLL
    {
        public string settingItem { get; }
        public string PostSave(string preSave);
        public string PreOpen(string fileData);
    }
}
