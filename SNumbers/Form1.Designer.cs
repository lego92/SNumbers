namespace SNumbers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtbxFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenConfigFile = new System.Windows.Forms.Button();
            this.btnExtractNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Location = new System.Drawing.Point(221, 46);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(248, 20);
            this.txtbxFilePath.TabIndex = 0;
            // 
            // btnOpenConfigFile
            // 
            this.btnOpenConfigFile.Location = new System.Drawing.Point(67, 36);
            this.btnOpenConfigFile.Name = "btnOpenConfigFile";
            this.btnOpenConfigFile.Size = new System.Drawing.Size(115, 38);
            this.btnOpenConfigFile.TabIndex = 1;
            this.btnOpenConfigFile.Text = "Открыть файл конфигурации";
            this.btnOpenConfigFile.UseVisualStyleBackColor = true;
            this.btnOpenConfigFile.Click += new System.EventHandler(this.btnOpenConfigFile_Click);
            // 
            // btnExtractNumbers
            // 
            this.btnExtractNumbers.Enabled = false;
            this.btnExtractNumbers.Location = new System.Drawing.Point(180, 106);
            this.btnExtractNumbers.Name = "btnExtractNumbers";
            this.btnExtractNumbers.Size = new System.Drawing.Size(108, 38);
            this.btnExtractNumbers.TabIndex = 2;
            this.btnExtractNumbers.Text = "Извлечь номера";
            this.btnExtractNumbers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 168);
            this.Controls.Add(this.btnExtractNumbers);
            this.Controls.Add(this.btnOpenConfigFile);
            this.Controls.Add(this.txtbxFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtbxFilePath;
        private System.Windows.Forms.Button btnOpenConfigFile;
        private System.Windows.Forms.Button btnExtractNumbers;
    }
}

