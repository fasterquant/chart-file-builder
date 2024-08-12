
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
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            label3 = new System.Windows.Forms.Label();
            cbSetupType = new System.Windows.Forms.ComboBox();
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
            lblSymbol.Location = new System.Drawing.Point(46, 9);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new System.Drawing.Size(47, 15);
            lblSymbol.TabIndex = 1;
            lblSymbol.Text = "Symbol";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(62, 39);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            lblDate.Click += lblDate_Click;
            // 
            // tbSymbol
            // 
            tbSymbol.Location = new System.Drawing.Point(106, 1);
            tbSymbol.Name = "tbSymbol";
            tbSymbol.Size = new System.Drawing.Size(100, 23);
            tbSymbol.TabIndex = 3;
            // 
            // tbDate
            // 
            tbDate.Location = new System.Drawing.Point(106, 35);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(100, 23);
            tbDate.TabIndex = 4;
            // 
            // lblSuClose
            // 
            lblSuClose.AutoSize = true;
            lblSuClose.Location = new System.Drawing.Point(270, 9);
            lblSuClose.Name = "lblSuClose";
            lblSuClose.Size = new System.Drawing.Size(69, 15);
            lblSuClose.TabIndex = 5;
            lblSuClose.Text = "Setup Close";
            lblSuClose.Click += lblSuClose_Click;
            // 
            // lblBoClose
            // 
            lblBoClose.AutoSize = true;
            lblBoClose.Location = new System.Drawing.Point(253, 39);
            lblBoClose.Name = "lblBoClose";
            lblBoClose.Size = new System.Drawing.Size(86, 15);
            lblBoClose.TabIndex = 6;
            lblBoClose.Text = "Breakout Close";
            lblBoClose.Click += lblBoClose_Click;
            // 
            // tbSuClose
            // 
            tbSuClose.Location = new System.Drawing.Point(355, 6);
            tbSuClose.Name = "tbSuClose";
            tbSuClose.Size = new System.Drawing.Size(100, 23);
            tbSuClose.TabIndex = 7;
            // 
            // tbBoClose
            // 
            tbBoClose.Location = new System.Drawing.Point(355, 39);
            tbBoClose.Name = "tbBoClose";
            tbBoClose.Size = new System.Drawing.Size(100, 23);
            tbBoClose.TabIndex = 8;
            // 
            // lblSwingHigh
            // 
            lblSwingHigh.AutoSize = true;
            lblSwingHigh.Location = new System.Drawing.Point(270, 77);
            lblSwingHigh.Name = "lblSwingHigh";
            lblSwingHigh.Size = new System.Drawing.Size(68, 15);
            lblSwingHigh.TabIndex = 9;
            lblSwingHigh.Text = "Swing High";
            // 
            // tbSwingHigh
            // 
            tbSwingHigh.Location = new System.Drawing.Point(355, 74);
            tbSwingHigh.Name = "tbSwingHigh";
            tbSwingHigh.Size = new System.Drawing.Size(100, 23);
            tbSwingHigh.TabIndex = 10;
            // 
            // tbOutputDirectory
            // 
            tbOutputDirectory.Location = new System.Drawing.Point(147, 151);
            tbOutputDirectory.Name = "tbOutputDirectory";
            tbOutputDirectory.Size = new System.Drawing.Size(373, 23);
            tbOutputDirectory.TabIndex = 11;
            tbOutputDirectory.Text = "C:\\\\deepdive\\\\charts\\\\";
            // 
            // lblOutPutDirectory
            // 
            lblOutPutDirectory.AutoSize = true;
            lblOutPutDirectory.Location = new System.Drawing.Point(12, 154);
            lblOutPutDirectory.Name = "lblOutPutDirectory";
            lblOutPutDirectory.Size = new System.Drawing.Size(96, 15);
            lblOutPutDirectory.TabIndex = 12;
            lblOutPutDirectory.Text = "Output Directory";
            // 
            // cmdGenerateFiles
            // 
            cmdGenerateFiles.Location = new System.Drawing.Point(12, 205);
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
            label2.Location = new System.Drawing.Point(1, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 15);
            label2.TabIndex = 15;
            label2.Text = "Week Base Count";
            // 
            // tbWeekBaseCount
            // 
            tbWeekBaseCount.Location = new System.Drawing.Point(106, 74);
            tbWeekBaseCount.Name = "tbWeekBaseCount";
            tbWeekBaseCount.Size = new System.Drawing.Size(100, 23);
            tbWeekBaseCount.TabIndex = 16;
            // 
            // lblSuFn
            // 
            lblSuFn.AutoSize = true;
            lblSuFn.Location = new System.Drawing.Point(12, 258);
            lblSuFn.Name = "lblSuFn";
            lblSuFn.Size = new System.Drawing.Size(88, 15);
            lblSuFn.TabIndex = 17;
            lblSuFn.Text = "Setup Filename";
            // 
            // lblBoFn
            // 
            lblBoFn.AutoSize = true;
            lblBoFn.Location = new System.Drawing.Point(12, 286);
            lblBoFn.Name = "lblBoFn";
            lblBoFn.Size = new System.Drawing.Size(105, 15);
            lblBoFn.TabIndex = 18;
            lblBoFn.Text = "Breakout Filename";
            // 
            // lblResultFn
            // 
            lblResultFn.AutoSize = true;
            lblResultFn.Location = new System.Drawing.Point(18, 318);
            lblResultFn.Name = "lblResultFn";
            lblResultFn.Size = new System.Drawing.Size(90, 15);
            lblResultFn.TabIndex = 19;
            lblResultFn.Text = "Result Filename";
            // 
            // tbSetupFilename
            // 
            tbSetupFilename.Location = new System.Drawing.Point(133, 255);
            tbSetupFilename.Name = "tbSetupFilename";
            tbSetupFilename.Size = new System.Drawing.Size(221, 23);
            tbSetupFilename.TabIndex = 20;
            // 
            // tbBreakoutFilename
            // 
            tbBreakoutFilename.Location = new System.Drawing.Point(133, 286);
            tbBreakoutFilename.Name = "tbBreakoutFilename";
            tbBreakoutFilename.Size = new System.Drawing.Size(221, 23);
            tbBreakoutFilename.TabIndex = 21;
            // 
            // tbResultFilename
            // 
            tbResultFilename.Location = new System.Drawing.Point(133, 315);
            tbResultFilename.Name = "tbResultFilename";
            tbResultFilename.Size = new System.Drawing.Size(221, 23);
            tbResultFilename.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(270, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 15);
            label3.TabIndex = 23;
            label3.Text = "Setup Type";
            // 
            // cbSetupType
            // 
            cbSetupType.FormattingEnabled = true;
            cbSetupType.Items.AddRange(new object[] { "CB", "CH", "Flag", "HTF", "IHS", "VCP" });
            cbSetupType.Location = new System.Drawing.Point(355, 112);
            cbSetupType.Name = "cbSetupType";
            cbSetupType.Size = new System.Drawing.Size(121, 23);
            cbSetupType.TabIndex = 24;
            // 
            // ChartFileBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(679, 450);
            Controls.Add(cbSetupType);
            Controls.Add(label3);
            Controls.Add(tbResultFilename);
            Controls.Add(tbBreakoutFilename);
            Controls.Add(tbSetupFilename);
            Controls.Add(lblResultFn);
            Controls.Add(lblBoFn);
            Controls.Add(lblSuFn);
            Controls.Add(tbWeekBaseCount);
            Controls.Add(label2);
            Controls.Add(cmdGenerateFiles);
            Controls.Add(lblOutPutDirectory);
            Controls.Add(tbOutputDirectory);
            Controls.Add(tbSwingHigh);
            Controls.Add(lblSwingHigh);
            Controls.Add(tbBoClose);
            Controls.Add(tbSuClose);
            Controls.Add(lblBoClose);
            Controls.Add(lblSuClose);
            Controls.Add(tbDate);
            Controls.Add(tbSymbol);
            Controls.Add(lblDate);
            Controls.Add(lblSymbol);
            Controls.Add(label1);
            Name = "ChartFileBuilder";
            Text = "Chart File Builder";
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSetupType;
    }
}

