using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class KeyInputForm : Form
    {
        public string Key { get; private set; }
        public string IV { get; private set; }
        public KeyInputForm()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if ((Key = tbKey.Text) != "" && (IV = tbIV.Text) != "")
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
