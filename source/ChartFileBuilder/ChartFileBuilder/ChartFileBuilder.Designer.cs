
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbSymbol = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lblSuClose = new System.Windows.Forms.Label();
            this.lblBoClose = new System.Windows.Forms.Label();
            this.tbSuClose = new System.Windows.Forms.TextBox();
            this.tbBoClose = new System.Windows.Forms.TextBox();
            this.lblSwingHigh = new System.Windows.Forms.Label();
            this.tbSwingHigh = new System.Windows.Forms.TextBox();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.lblOutPutDirectory = new System.Windows.Forms.Label();
            this.cmdGenerateFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeekBaseCount = new System.Windows.Forms.TextBox();
            this.lblSuFn = new System.Windows.Forms.Label();
            this.lblBoFn = new System.Windows.Forms.Label();
            this.lblResultFn = new System.Windows.Forms.Label();
            this.tbSetupFilename = new System.Windows.Forms.TextBox();
            this.tbBreakoutFilename = new System.Windows.Forms.TextBox();
            this.tbResultFilename = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, -72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(46, 9);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(47, 15);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "Symbol";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(62, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // tbSymbol
            // 
            this.tbSymbol.Location = new System.Drawing.Point(106, 1);
            this.tbSymbol.Name = "tbSymbol";
            this.tbSymbol.Size = new System.Drawing.Size(100, 23);
            this.tbSymbol.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(106, 35);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 23);
            this.tbDate.TabIndex = 4;
            // 
            // lblSuClose
            // 
            this.lblSuClose.AutoSize = true;
            this.lblSuClose.Location = new System.Drawing.Point(270, 9);
            this.lblSuClose.Name = "lblSuClose";
            this.lblSuClose.Size = new System.Drawing.Size(69, 15);
            this.lblSuClose.TabIndex = 5;
            this.lblSuClose.Text = "Setup Close";
            this.lblSuClose.Click += new System.EventHandler(this.lblSuClose_Click);
            // 
            // lblBoClose
            // 
            this.lblBoClose.AutoSize = true;
            this.lblBoClose.Location = new System.Drawing.Point(253, 39);
            this.lblBoClose.Name = "lblBoClose";
            this.lblBoClose.Size = new System.Drawing.Size(86, 15);
            this.lblBoClose.TabIndex = 6;
            this.lblBoClose.Text = "Breakout Close";
            this.lblBoClose.Click += new System.EventHandler(this.lblBoClose_Click);
            // 
            // tbSuClose
            // 
            this.tbSuClose.Location = new System.Drawing.Point(355, 6);
            this.tbSuClose.Name = "tbSuClose";
            this.tbSuClose.Size = new System.Drawing.Size(100, 23);
            this.tbSuClose.TabIndex = 7;
            // 
            // tbBoClose
            // 
            this.tbBoClose.Location = new System.Drawing.Point(355, 39);
            this.tbBoClose.Name = "tbBoClose";
            this.tbBoClose.Size = new System.Drawing.Size(100, 23);
            this.tbBoClose.TabIndex = 8;
            // 
            // lblSwingHigh
            // 
            this.lblSwingHigh.AutoSize = true;
            this.lblSwingHigh.Location = new System.Drawing.Point(270, 77);
            this.lblSwingHigh.Name = "lblSwingHigh";
            this.lblSwingHigh.Size = new System.Drawing.Size(68, 15);
            this.lblSwingHigh.TabIndex = 9;
            this.lblSwingHigh.Text = "Swing High";
            // 
            // tbSwingHigh
            // 
            this.tbSwingHigh.Location = new System.Drawing.Point(355, 74);
            this.tbSwingHigh.Name = "tbSwingHigh";
            this.tbSwingHigh.Size = new System.Drawing.Size(100, 23);
            this.tbSwingHigh.TabIndex = 10;
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(165, 112);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(373, 23);
            this.tbOutputDirectory.TabIndex = 11;
            this.tbOutputDirectory.Text = "C:\\\\deepdive\\\\charts\\\\";
            // 
            // lblOutPutDirectory
            // 
            this.lblOutPutDirectory.AutoSize = true;
            this.lblOutPutDirectory.Location = new System.Drawing.Point(30, 112);
            this.lblOutPutDirectory.Name = "lblOutPutDirectory";
            this.lblOutPutDirectory.Size = new System.Drawing.Size(96, 15);
            this.lblOutPutDirectory.TabIndex = 12;
            this.lblOutPutDirectory.Text = "Output Directory";
            // 
            // cmdGenerateFiles
            // 
            this.cmdGenerateFiles.Location = new System.Drawing.Point(30, 166);
            this.cmdGenerateFiles.Name = "cmdGenerateFiles";
            this.cmdGenerateFiles.Size = new System.Drawing.Size(119, 22);
            this.cmdGenerateFiles.TabIndex = 13;
            this.cmdGenerateFiles.Text = "Generate Files";
            this.cmdGenerateFiles.UseVisualStyleBackColor = true;
            this.cmdGenerateFiles.Click += new System.EventHandler(this.cmdGenerateFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Week Base Count";
            // 
            // tbWeekBaseCount
            // 
            this.tbWeekBaseCount.Location = new System.Drawing.Point(106, 74);
            this.tbWeekBaseCount.Name = "tbWeekBaseCount";
            this.tbWeekBaseCount.Size = new System.Drawing.Size(100, 23);
            this.tbWeekBaseCount.TabIndex = 16;
            // 
            // lblSuFn
            // 
            this.lblSuFn.AutoSize = true;
            this.lblSuFn.Location = new System.Drawing.Point(30, 219);
            this.lblSuFn.Name = "lblSuFn";
            this.lblSuFn.Size = new System.Drawing.Size(88, 15);
            this.lblSuFn.TabIndex = 17;
            this.lblSuFn.Text = "Setup Filename";
            // 
            // lblBoFn
            // 
            this.lblBoFn.AutoSize = true;
            this.lblBoFn.Location = new System.Drawing.Point(30, 247);
            this.lblBoFn.Name = "lblBoFn";
            this.lblBoFn.Size = new System.Drawing.Size(105, 15);
            this.lblBoFn.TabIndex = 18;
            this.lblBoFn.Text = "Breakout Filename";
            // 
            // lblResultFn
            // 
            this.lblResultFn.AutoSize = true;
            this.lblResultFn.Location = new System.Drawing.Point(36, 279);
            this.lblResultFn.Name = "lblResultFn";
            this.lblResultFn.Size = new System.Drawing.Size(90, 15);
            this.lblResultFn.TabIndex = 19;
            this.lblResultFn.Text = "Result Filename";
            // 
            // tbSetupFilename
            // 
            this.tbSetupFilename.Location = new System.Drawing.Point(151, 216);
            this.tbSetupFilename.Name = "tbSetupFilename";
            this.tbSetupFilename.Size = new System.Drawing.Size(221, 23);
            this.tbSetupFilename.TabIndex = 20;
            // 
            // tbBreakoutFilename
            // 
            this.tbBreakoutFilename.Location = new System.Drawing.Point(151, 247);
            this.tbBreakoutFilename.Name = "tbBreakoutFilename";
            this.tbBreakoutFilename.Size = new System.Drawing.Size(221, 23);
            this.tbBreakoutFilename.TabIndex = 21;
            // 
            // tbResultFilename
            // 
            this.tbResultFilename.Location = new System.Drawing.Point(151, 276);
            this.tbResultFilename.Name = "tbResultFilename";
            this.tbResultFilename.Size = new System.Drawing.Size(221, 23);
            this.tbResultFilename.TabIndex = 22;
            // 
            // ChartFileBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.tbResultFilename);
            this.Controls.Add(this.tbBreakoutFilename);
            this.Controls.Add(this.tbSetupFilename);
            this.Controls.Add(this.lblResultFn);
            this.Controls.Add(this.lblBoFn);
            this.Controls.Add(this.lblSuFn);
            this.Controls.Add(this.tbWeekBaseCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdGenerateFiles);
            this.Controls.Add(this.lblOutPutDirectory);
            this.Controls.Add(this.tbOutputDirectory);
            this.Controls.Add(this.tbSwingHigh);
            this.Controls.Add(this.lblSwingHigh);
            this.Controls.Add(this.tbBoClose);
            this.Controls.Add(this.tbSuClose);
            this.Controls.Add(this.lblBoClose);
            this.Controls.Add(this.lblSuClose);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbSymbol);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.label1);
            this.Name = "ChartFileBuilder";
            this.Text = "Chart File Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

