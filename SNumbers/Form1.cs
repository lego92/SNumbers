﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNumbers
{
    public partial class Form1 : Form
    {
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
        }

        private void EAParser()
        {

        }
    }
}
