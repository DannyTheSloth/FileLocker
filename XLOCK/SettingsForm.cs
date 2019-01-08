using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLOCK
{
    public partial class btnSetExtension : Form
    {
        public btnSetExtension()
        {
            InitializeComponent();
        }
        public string FilePath = Environment.CurrentDirectory + @"\XLOCKFiles\" + "XLOCKSettings.txt";
        private void btnExtension_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath))
                File.Create(FilePath);

        }
    }
}
