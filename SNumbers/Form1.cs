using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SNumbers
{
    public partial class Form1 : Form
    {
        string filepath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenConfigFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файл конфигурации МикроСРЗ (.ea)| *.ea";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbxFilePath.Text = openFileDialog1.FileName;
            }

            btnExtractNumbers.Enabled = true;
        }

        private void btnExtractNumbers_Click(object sender, EventArgs e)
        {
            XmlDocument config = new XmlDocument();

            config.Load(filepath);

            XmlNode root = config.DocumentElement;
        }
    }
}
