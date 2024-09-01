
using System;

namespace ChartFileBuilder
{
    partial class ChartFileBuilder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            lblSymbol = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            tbSymbol = new System.Windows.Forms.TextBox();
            tbDate = new System.Windows.Forms.TextBox();
            lblSuClose = new System.Windows.Forms.Label();
            lblBoClose = new System.Windows.Forms.Label();
            tbSuClose = new System.Windows.Forms.TextBox();
            tbBoClose = new System.Windows.Forms.TextBox();
            lblSwingHigh = new System.Windows.Forms.Label();
            tbSwingHigh = new System.Windows.Forms.TextBox();
            tbOutputDirectory = new System.Windows.Forms.TextBox();
            lblOutPutDirectory = new System.Windows.Forms.Label();
            cmdGenerateFiles = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            tbWeekBaseCount = new System.Windows.Forms.TextBox();
            lblSuFn = new System.Windows.Forms.Label();
            lblBoFn = new System.Windows.Forms.Label();
            lblResultFn = new System.Windows.Forms.Label();
            tbSetupFilename = new System.Windows.Forms.TextBox();
            tbBreakoutFilename = new System.Windows.Forms.TextBox();
            tbResultFilename = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            cbSetupType = new System.Windows.Forms.ComboBox();
            tabControl = new System.Windows.Forms.TabControl();
            tpBatch = new System.Windows.Forms.TabPage();
            tbSignalFile = new System.Windows.Forms.TextBox();
            btnOpenSignalFile = new System.Windows.Forms.Button();
            tbTradeFile = new System.Windows.Forms.TextBox();
            btnOpenTradeFile = new System.Windows.Forms.Button();
            btnGenerateFilesBatch = new System.Windows.Forms.Button();
            tpSingle = new System.Windows.Forms.TabPage();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tbOutputDir = new System.Windows.Forms.TextBox();
            btnOpenOutputDir = new System.Windows.Forms.Button();
            tabControl.SuspendLayout();
            tpBatch.SuspendLayout();
            tpSingle.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, -72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Location = new System.Drawing.Point(55, 20);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new System.Drawing.Size(47, 15);
            lblSymbol.TabIndex = 1;
            lblSymbol.Text = "Symbol";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(71, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // tbSymbol
            // 
            tbSymbol.Location = new System.Drawing.Point(115, 12);
            tbSymbol.Name = "tbSymbol";
            tbSymbol.Size = new System.Drawing.Size(100, 23);
            tbSymbol.TabIndex = 3;
            // 
            // tbDate
            // 
            tbDate.Location = new System.Drawing.Point(115, 46);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(100, 23);
            tbDate.TabIndex = 4;
            // 
            // lblSuClose
            // 
            lblSuClose.AutoSize = true;
            lblSuClose.Location = new System.Drawing.Point(279, 20);
            lblSuClose.Name = "lblSuClose";
            lblSuClose.Size = new System.Drawing.Size(69, 15);
            lblSuClose.TabIndex = 5;
            lblSuClose.Text = "Setup Close";
            // 
            // lblBoClose
            // 
            lblBoClose.AutoSize = true;
            lblBoClose.Location = new System.Drawing.Point(262, 50);
            lblBoClose.Name = "lblBoClose";
            lblBoClose.Size = new System.Drawing.Size(86, 15);
            lblBoClose.TabIndex = 6;
            lblBoClose.Text = "Breakout Close";
            // 
            // tbSuClose
            // 
            tbSuClose.Location = new System.Drawing.Point(364, 17);
            tbSuClose.Name = "tbSuClose";
            tbSuClose.Size = new System.Drawing.Size(100, 23);
            tbSuClose.TabIndex = 7;
            // 
            // tbBoClose
            // 
            tbBoClose.Location = new System.Drawing.Point(364, 50);
            tbBoClose.Name = "tbBoClose";
            tbBoClose.Size = new System.Drawing.Size(100, 23);
            tbBoClose.TabIndex = 8;
            // 
            // lblSwingHigh
            // 
            lblSwingHigh.AutoSize = true;
            lblSwingHigh.Location = new System.Drawing.Point(279, 88);
            lblSwingHigh.Name = "lblSwingHigh";
            lblSwingHigh.Size = new System.Drawing.Size(68, 15);
            lblSwingHigh.TabIndex = 9;
            lblSwingHigh.Text = "Swing High";
            // 
            // tbSwingHigh
            // 
            tbSwingHigh.Location = new System.Drawing.Point(364, 85);
            tbSwingHigh.Name = "tbSwingHigh";
            tbSwingHigh.Size = new System.Drawing.Size(100, 23);
            tbSwingHigh.TabIndex = 10;
            // 
            // tbOutputDirectory
            // 
            tbOutputDirectory.Location = new System.Drawing.Point(156, 162);
            tbOutputDirectory.Name = "tbOutputDirectory";
            tbOutputDirectory.Size = new System.Drawing.Size(373, 23);
            tbOutputDirectory.TabIndex = 11;
            tbOutputDirectory.Text = "C:\\\\deepdive\\\\charts\\\\";
            // 
            // lblOutPutDirectory
            // 
            lblOutPutDirectory.AutoSize = true;
            lblOutPutDirectory.Location = new System.Drawing.Point(21, 165);
            lblOutPutDirectory.Name = "lblOutPutDirectory";
            lblOutPutDirectory.Size = new System.Drawing.Size(96, 15);
            lblOutPutDirectory.TabIndex = 12;
            lblOutPutDirectory.Text = "Output Directory";
            // 
            // cmdGenerateFiles
            // 
            cmdGenerateFiles.Location = new System.Drawing.Point(15, 270);
            cmdGenerateFiles.Name = "cmdGenerateFiles";
            cmdGenerateFiles.Size = new System.Drawing.Size(119, 22);
            cmdGenerateFiles.TabIndex = 13;
            cmdGenerateFiles.Text = "Generate Files";
            cmdGenerateFiles.UseVisualStyleBackColor = true;
            cmdGenerateFiles.Click += cmdGenerateFiles_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 15);
            label2.TabIndex = 15;
            label2.Text = "Week Base Count";
            // 
            // tbWeekBaseCount
            // 
            tbWeekBaseCount.Location = new System.Drawing.Point(115, 85);
            tbWeekBaseCount.Name = "tbWeekBaseCount";
            tbWeekBaseCount.Size = new System.Drawing.Size(100, 23);
            tbWeekBaseCount.TabIndex = 16;
            // 
            // lblSuFn
            // 
            lblSuFn.AutoSize = true;
            lblSuFn.Location = new System.Drawing.Point(15, 323);
            lblSuFn.Name = "lblSuFn";
            lblSuFn.Size = new System.Drawing.Size(88, 15);
            lblSuFn.TabIndex = 17;
            lblSuFn.Text = "Setup Filename";
            // 
            // lblBoFn
            // 
            lblBoFn.AutoSize = true;
            lblBoFn.Location = new System.Drawing.Point(15, 351);
            lblBoFn.Name = "lblBoFn";
            lblBoFn.Size = new System.Drawing.Size(105, 15);
            lblBoFn.TabIndex = 18;
            lblBoFn.Text = "Breakout Filename";
            // 
            // lblResultFn
            // 
            lblResultFn.AutoSize = true;
            lblResultFn.Location = new System.Drawing.Point(21, 383);
            lblResultFn.Name = "lblResultFn";
            lblResultFn.Size = new System.Drawing.Size(90, 15);
            lblResultFn.TabIndex = 19;
            lblResultFn.Text = "Result Filename";
            // 
            // tbSetupFilename
            // 
            tbSetupFilename.Location = new System.Drawing.Point(136, 320);
            tbSetupFilename.Name = "tbSetupFilename";
            tbSetupFilename.Size = new System.Drawing.Size(221, 23);
            tbSetupFilename.TabIndex = 20;
            // 
            // tbBreakoutFilename
            // 
            tbBreakoutFilename.Location = new System.Drawing.Point(136, 351);
            tbBreakoutFilename.Name = "tbBreakoutFilename";
            tbBreakoutFilename.Size = new System.Drawing.Size(221, 23);
            tbBreakoutFilename.TabIndex = 21;
            // 
            // tbResultFilename
            // 
            tbResultFilename.Location = new System.Drawing.Point(136, 380);
            tbResultFilename.Name = "tbResultFilename";
            tbResultFilename.Size = new System.Drawing.Size(221, 23);
            tbResultFilename.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(279, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 15);
            label3.TabIndex = 23;
            label3.Text = "Setup Type";
            // 
            // cbSetupType
            // 
            cbSetupType.FormattingEnabled = true;
            cbSetupType.Items.AddRange(new object[] { "3C", "CB", "CH", "Flag", "HTF", "IHS", "VCP", "Surf" });
            cbSetupType.Location = new System.Drawing.Point(364, 123);
            cbSetupType.Name = "cbSetupType";
            cbSetupType.Size = new System.Drawing.Size(121, 23);
            cbSetupType.TabIndex = 24;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpBatch);
            tabControl.Controls.Add(tpSingle);
            tabControl.Location = new System.Drawing.Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(800, 445);
            tabControl.TabIndex = 25;
            // 
            // tpBatch
            // 
            tpBatch.Controls.Add(tbOutputDir);
            tpBatch.Controls.Add(btnOpenOutputDir);
            tpBatch.Controls.Add(tbSignalFile);
            tpBatch.Controls.Add(btnOpenSignalFile);
            tpBatch.Controls.Add(tbTradeFile);
            tpBatch.Controls.Add(btnOpenTradeFile);
            tpBatch.Controls.Add(btnGenerateFilesBatch);
            tpBatch.Location = new System.Drawing.Point(4, 24);
            tpBatch.Name = "tpBatch";
            tpBatch.Padding = new System.Windows.Forms.Padding(3);
            tpBatch.Size = new System.Drawing.Size(792, 417);
            tpBatch.TabIndex = 0;
            tpBatch.Text = "Batch";
            tpBatch.UseVisualStyleBackColor = true;
            // 
            // tbSignalFile
            // 
            tbSignalFile.Location = new System.Drawing.Point(169, 109);
            tbSignalFile.Name = "tbSignalFile";
            tbSignalFile.Size = new System.Drawing.Size(585, 23);
            tbSignalFile.TabIndex = 4;
            // 
            // btnOpenSignalFile
            // 
            btnOpenSignalFile.Location = new System.Drawing.Point(36, 109);
            btnOpenSignalFile.Name = "btnOpenSignalFile";
            btnOpenSignalFile.Size = new System.Drawing.Size(109, 23);
            btnOpenSignalFile.TabIndex = 3;
            btnOpenSignalFile.Text = "Open Signal File";
            btnOpenSignalFile.UseVisualStyleBackColor = true;
            btnOpenSignalFile.Click += btnOpenSignalFile_Click;
            // 
            // tbTradeFile
            // 
            tbTradeFile.Location = new System.Drawing.Point(169, 68);
            tbTradeFile.Name = "tbTradeFile";
            tbTradeFile.Size = new System.Drawing.Size(585, 23);
            tbTradeFile.TabIndex = 2;
            // 
            // btnOpenTradeFile
            // 
            btnOpenTradeFile.Location = new System.Drawing.Point(36, 68);
            btnOpenTradeFile.Name = "btnOpenTradeFile";
            btnOpenTradeFile.Size = new System.Drawing.Size(97, 23);
            btnOpenTradeFile.TabIndex = 1;
            btnOpenTradeFile.Text = "Open Trade File";
            btnOpenTradeFile.UseVisualStyleBackColor = true;
            btnOpenTradeFile.Click += btnOpenTradeFile_Click;
            // 
            // btnGenerateFilesBatch
            // 
            btnGenerateFilesBatch.Location = new System.Drawing.Point(36, 226);
            btnGenerateFilesBatch.Name = "btnGenerateFilesBatch";
            btnGenerateFilesBatch.Size = new System.Drawing.Size(147, 28);
            btnGenerateFilesBatch.TabIndex = 0;
            btnGenerateFilesBatch.Text = "Generate Chart Files";
            btnGenerateFilesBatch.UseVisualStyleBackColor = true;
            btnGenerateFilesBatch.Click += btnGenerateFilesBatch_Click;
            // 
            // tpSingle
            // 
            tpSingle.Controls.Add(tbResultFilename);
            tpSingle.Controls.Add(cbSetupType);
            tpSingle.Controls.Add(cmdGenerateFiles);
            tpSingle.Controls.Add(label3);
            tpSingle.Controls.Add(tbSetupFilename);
            tpSingle.Controls.Add(tbWeekBaseCount);
            tpSingle.Controls.Add(lblResultFn);
            tpSingle.Controls.Add(label2);
            tpSingle.Controls.Add(lblSuFn);
            tpSingle.Controls.Add(lblOutPutDirectory);
            tpSingle.Controls.Add(tbBreakoutFilename);
            tpSingle.Controls.Add(tbOutputDirectory);
            tpSingle.Controls.Add(tbSwingHigh);
            tpSingle.Controls.Add(lblBoFn);
            tpSingle.Controls.Add(lblSwingHigh);
            tpSingle.Controls.Add(lblSymbol);
            tpSingle.Controls.Add(tbBoClose);
            tpSingle.Controls.Add(lblDate);
            tpSingle.Controls.Add(tbSuClose);
            tpSingle.Controls.Add(tbSymbol);
            tpSingle.Controls.Add(lblBoClose);
            tpSingle.Controls.Add(tbDate);
            tpSingle.Controls.Add(lblSuClose);
            tpSingle.Location = new System.Drawing.Point(4, 24);
            tpSingle.Name = "tpSingle";
            tpSingle.Padding = new System.Windows.Forms.Padding(3);
            tpSingle.Size = new System.Drawing.Size(792, 417);
            tpSingle.TabIndex = 1;
            tpSingle.Text = "Single";
            tpSingle.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbOutputDir
            // 
            tbOutputDir.Location = new System.Drawing.Point(169, 152);
            tbOutputDir.Name = "tbOutputDir";
            tbOutputDir.Size = new System.Drawing.Size(585, 23);
            tbOutputDir.TabIndex = 6;
            // 
            // btnOpenOutputDir
            // 
            btnOpenOutputDir.Location = new System.Drawing.Point(36, 152);
            btnOpenOutputDir.Name = "btnOpenOutputDir";
            btnOpenOutputDir.Size = new System.Drawing.Size(109, 23);
            btnOpenOutputDir.TabIndex = 5;
            btnOpenOutputDir.Text = "Open Output Directory";
            btnOpenOutputDir.UseVisualStyleBackColor = true;
            btnOpenOutputDir.Click += btnOpenOutputDir_Click;
            // 
            // ChartFileBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(919, 469);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Name = "ChartFileBuilder";
            Text = "Chart File Builder";
            tabControl.ResumeLayout(false);
            tpBatch.ResumeLayout(false);
            tpBatch.PerformLayout();
            tpSingle.ResumeLayout(false);
            tpSingle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblBoClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblSuClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbSymbol;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lblSuClose;
        private System.Windows.Forms.Label lblBoClose;
        private System.Windows.Forms.TextBox tbSuClose;
        private System.Windows.Forms.TextBox tbBoClose;
        private System.Windows.Forms.Label lblSwingHigh;
        private System.Windows.Forms.TextBox tbSwingHigh;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Label lblOutPutDirectory;
        private System.Windows.Forms.Button cmdGenerateFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeekBaseCount;
        private System.Windows.Forms.Label lblSuFn;
        private System.Windows.Forms.Label lblBoFn;
        private System.Windows.Forms.Label lblResultFn;
        private System.Windows.Forms.TextBox tbSetupFilename;
        private System.Windows.Forms.TextBox tbBreakoutFilename;
        private System.Windows.Forms.TextBox tbResultFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSetupType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpBatch;
        private System.Windows.Forms.TabPage tpSingle;
        private System.Windows.Forms.Button btnGenerateFilesBatch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbSignalFile;
        private System.Windows.Forms.Button btnOpenSignalFile;
        private System.Windows.Forms.TextBox tbTradeFile;
        private System.Windows.Forms.Button btnOpenTradeFile;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.Button btnOpenOutputDir;
    }
}

