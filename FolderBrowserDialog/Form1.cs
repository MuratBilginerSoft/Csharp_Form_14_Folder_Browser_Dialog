using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Input Output

namespace FolderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DialogResult Sonuc = folderBrowserDialog1.ShowDialog();

            if (Sonuc==DialogResult.OK)
            {
                string Path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo KlasörBilgi = new DirectoryInfo(Path);
                FileInfo[] Dosyalar = KlasörBilgi.GetFiles();
                listBox1.Items.AddRange(Dosyalar);
            }

        }
    }
}
