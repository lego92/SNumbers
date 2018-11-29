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
            this.lblFilePathText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл конфигурации МикроСРЗ (.ea)| *.ea";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text file(*.txt)|*.txt";
            // 
            // txtbxFilePath
            // 
            this.txtbxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFilePath.Location = new System.Drawing.Point(220, 55);
            this.txtbxFilePath.Name = "txtbxFilePath";
            this.txtbxFilePath.Size = new System.Drawing.Size(248, 22);
            this.txtbxFilePath.TabIndex = 0;
            // 
            // btnOpenConfigFile
            // 
            this.btnOpenConfigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenConfigFile.Location = new System.Drawing.Point(47, 29);
            this.btnOpenConfigFile.Name = "btnOpenConfigFile";
            this.btnOpenConfigFile.Size = new System.Drawing.Size(142, 59);
            this.btnOpenConfigFile.TabIndex = 1;
            this.btnOpenConfigFile.Text = "Открыть файл конфигурации";
            this.btnOpenConfigFile.UseVisualStyleBackColor = true;
            this.btnOpenConfigFile.Click += new System.EventHandler(this.btnOpenConfigFile_Click);
            // 
            // btnExtractNumbers
            // 
            this.btnExtractNumbers.Enabled = false;
            this.btnExtractNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtractNumbers.Location = new System.Drawing.Point(161, 120);
            this.btnExtractNumbers.Name = "btnExtractNumbers";
            this.btnExtractNumbers.Size = new System.Drawing.Size(143, 50);
            this.btnExtractNumbers.TabIndex = 2;
            this.btnExtractNumbers.Text = "Извлечь номера в текстовый файл";
            this.btnExtractNumbers.UseVisualStyleBackColor = true;
            this.btnExtractNumbers.Click += new System.EventHandler(this.btnExtractNumbers_Click);
            // 
            // lblFilePathText
            // 
            this.lblFilePathText.AutoSize = true;
            this.lblFilePathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilePathText.Location = new System.Drawing.Point(217, 29);
            this.lblFilePathText.Name = "lblFilePathText";
            this.lblFilePathText.Size = new System.Drawing.Size(46, 16);
            this.lblFilePathText.TabIndex = 3;
            this.lblFilePathText.Text = "Путь :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 194);
            this.Controls.Add(this.lblFilePathText);
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
        private System.Windows.Forms.Label lblFilePathText;
    }
}

