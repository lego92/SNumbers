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
using System.IO;

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
            //openFileDialog1.Filter = "Файл конфигурации МикроСРЗ (.ea)| *.ea";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                txtbxFilePath.Text = openFileDialog1.FileName;
                btnExtractNumbers.Enabled = true;
            }


        }

        private void btnExtractNumbers_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);//new StreamWriter(saveFileDialog1.FileName);

                XmlDocument config = new XmlDocument();

                config.Load(filepath);

                XmlNode root = config.DocumentElement;

                foreach (XmlNode node in root)
                {
                    if (node.Name == "ISA" || node.Name == "ISC")
                    {
                        foreach (XmlNode item in node.ChildNodes)
                        {
                            if (item.Name == "FACTORY_NUM")
                            {
                                streamWriter.WriteLine(item.InnerText);
                            }
                        }
                    }
                }

                streamWriter.Close();

                MessageBox.Show(" Номера датчиков сохранены в файл " + saveFileDialog1.FileName);
            }
        }
    }
}
