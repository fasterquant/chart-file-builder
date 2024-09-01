using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace ChartFileBuilder
{
    public partial class ChartFileBuilder : Form
    {

        private string _setupFileNameTemplate;
        private string _breakoutFileNameTemplate;
        private string _resultFileNameTemplate;

        private string _setupFileNameTemplateBatch;
        private string _breakoutFileNameTemplateBatch;
        private string _resultFileNameTemplateBatch;

        private const string _symbolPlaceHolder = "symbol";
        private const string _datePlaceHolder = "date";
        private const string _baseCountPlaceHolder = "baseCount";
        private const string _setupClosePercentGainPlaceHolder = "setupClosePercentGain";
        private const string _breakoutClosePercentGainPlaceHolder = "breakoutClosePercentGain";
        private const string _resultPercentGainPlaceHolder = "resultPercentGain";
        private const string _setupTypePlaceHolder = "setupType";

        public ChartFileBuilder()
        {
            _setupFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_0_Setup_BCW{_baseCountPlaceHolder}_{_setupTypePlaceHolder}.JPG";
            _breakoutFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_1_Breakout_{_setupTypePlaceHolder}.JPG";
            _resultFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_2_Result_SU{_setupClosePercentGainPlaceHolder}_BO{_breakoutClosePercentGainPlaceHolder}_{_setupTypePlaceHolder}.JPG";


            _setupFileNameTemplateBatch = $"{_datePlaceHolder}_{_symbolPlaceHolder}_0_Setup_BCW{_baseCountPlaceHolder}_{_setupTypePlaceHolder}.JPG";
            _breakoutFileNameTemplateBatch = $"{_datePlaceHolder}_{_symbolPlaceHolder}_1_Breakout_{_setupTypePlaceHolder}.JPG";
            _resultFileNameTemplateBatch = $"{_datePlaceHolder}_{_symbolPlaceHolder}_2_Result{_resultPercentGainPlaceHolder}_{_setupTypePlaceHolder}.JPG";

            InitializeComponent();

            tbTradeFile.Text = @"C:\repos\github\strategies\source\Tickblaze\StrategyDefinitions\Breakout\2018-2019Results.csv";
            tbSignalFile.Text = @"C:\repos\github\strategies\source\Tickblaze\StrategyDefinitions\Breakout\SignalsBacktest.csv";
        }

        private void cmdGenerateFiles_Click(object sender, EventArgs e)
        {
            var sfn = CreateSetupFileName(_setupFileNameTemplate, tbDate.Text, tbSymbol.Text, tbWeekBaseCount.Text, cbSetupType.Text);
            var bofn = CreateBreakoutFileName(_breakoutFileNameTemplate, tbDate.Text, tbSymbol.Text, cbSetupType.Text);

            var swingHigh = Convert.ToDouble(tbSwingHigh.Text);
            var suClose = Convert.ToDouble(tbSuClose.Text);
            var boClose = Convert.ToDouble(tbBoClose.Text);


            var suPercentGain = Math.Round((swingHigh - suClose) / suClose * 100, 0);
            var boPercentGain = Math.Round((swingHigh - boClose) / boClose * 100, 0);

            var rfn = CreateResultFileName(_resultFileNameTemplate, tbDate.Text, tbSymbol.Text, cbSetupType.Text, suPercentGain.ToString(), boPercentGain.ToString());
            

            tbSetupFilename.Text = sfn;
            tbBreakoutFilename.Text = bofn;
            tbResultFilename.Text = rfn;

            if (!System.IO.Directory.Exists(tbOutputDirectory.Text))
            {
                System.IO.Directory.CreateDirectory(tbOutputDirectory.Text);
            }

            var file = new System.IO.StreamWriter(tbOutputDirectory.Text + sfn);
            file.Close();

            file = new System.IO.StreamWriter(tbOutputDirectory.Text + bofn);
            file.Close();

            file = new System.IO.StreamWriter(tbOutputDirectory.Text + rfn);
            file.Close();

        }

        private void btnOpenTradeFile_Click(object sender, EventArgs e)
        {
            openFile(sender, e, tbTradeFile);
        }

        private void btnOpenSignalFile_Click(object sender, EventArgs e)
        {
            openFile(sender, e, tbSignalFile);
        }

        private void openFile(object sender, EventArgs e, TextBox targetTb)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\repos\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    targetTb.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnGenerateFilesBatch_Click(object sender, EventArgs e)
        {
            var signals = ReadSignals(tbSignalFile.Text);
            var trades = ReadTrades(tbTradeFile.Text);
            var tradeDispInfos = GetTradeDispalyInfos(signals, trades);
            var currentFiles = Directory.GetFiles(tbOutputDir.Text);


            foreach (var tdp in tradeDispInfos)
            {
                var sfn = CreateSetupFileName(_setupFileNameTemplateBatch, tdp.Date, tdp.Symbol, tdp.WeekBaseCount.ToString(), tdp.Type);
                CreateChartFile(currentFiles, tdp.Date, tdp.Symbol, 0, sfn);

                var bofn = CreateBreakoutFileName(_breakoutFileNameTemplateBatch, tdp.Date, tdp.Symbol, tdp.Type);
                CreateChartFile(currentFiles, tdp.Date, tdp.Symbol, 1, bofn);

                var rfn = CreateResultFileName(_resultFileNameTemplateBatch, tdp.Date, tdp.Symbol, tdp.Type, tdp.ResultPercent.ToString());
                CreateChartFile(currentFiles, tdp.Date, tdp.Symbol, 2, rfn);
            }
        }

        private void CreateChartFile(string[] currentFiles, string date, string symbol, int fileSequenceNumber, string chartFileName)
        {
            var existingFile = GetMatchingFile(currentFiles, date, symbol, fileSequenceNumber);
            if (existingFile != null)
            {
                if (!existingFile.Contains(chartFileName))
                {
                    File.Move(existingFile, Path.Combine(tbOutputDir.Text, chartFileName));
                }
            }
            else
            {
                File.Create(Path.Combine(tbOutputDir.Text, chartFileName));
            }
        }
     
        private string CreateSetupFileName(string template, string date, string symbol, string weekBaseCount, string setupType)
        {
            var sfn = template.Replace(_datePlaceHolder, date);
            sfn = sfn.Replace(_symbolPlaceHolder, symbol);
            sfn = sfn.Replace(_baseCountPlaceHolder, weekBaseCount);
            sfn = sfn.Replace(_setupTypePlaceHolder, setupType);

            return sfn;
        }

        private string CreateBreakoutFileName(string template, string date, string symbol, string setupType)
        {
            var bofn = template.Replace(_datePlaceHolder, date);
            bofn = bofn.Replace(_symbolPlaceHolder, symbol);
            bofn = bofn.Replace(_setupTypePlaceHolder, setupType);

            return bofn;
        }

        private string CreateResultFileName(string template, string date, string symbol, string setupType, string suPercentGain, string boPercentGain)
        {
            return CreateResultFileName(template, date, symbol, setupType, suPercentGain, boPercentGain, "");
        }

        private string CreateResultFileName(string template, string date, string symbol, string setupType, string tradePercentGain)
        {
            return CreateResultFileName(template, date, symbol, setupType, "", "", tradePercentGain);
        }

        private string CreateResultFileName(string template, string date, string symbol, string setupType, string suPercentGain, string boPercentGain, string tradePercentGain)
        {
            var rfn = template.Replace(_datePlaceHolder, date);
            rfn = rfn.Replace(_symbolPlaceHolder, symbol);
            rfn = rfn.Replace(_setupClosePercentGainPlaceHolder, suPercentGain);
            rfn = rfn.Replace(_breakoutClosePercentGainPlaceHolder, boPercentGain);
            rfn = rfn.Replace(_resultPercentGainPlaceHolder, tradePercentGain);
            rfn = rfn.Replace(_setupTypePlaceHolder, setupType);

            return rfn;
        }

        private string GetMatchingFile(string[] currentFiles, string date, string symbol, int fileSequenceNumber)
        {
            return currentFiles.FirstOrDefault(f => f.Contains(date) && f.Contains(symbol) && f.Contains("_" + fileSequenceNumber.ToString() + "_"));
        }

        private List<TradeDispalyInfo> GetTradeDispalyInfos(List<Signal> signals, List<Trade> trades)
        {
            var tdis = new List<TradeDispalyInfo>();
            foreach (var trade in trades)
            {
                var signal = signals.Find(s => s.Date == trade.Date && s.Symbol == trade.Symbol);
                if (signal != null)
                {
                    var tdi = new TradeDispalyInfo(trade.Symbol, trade.Date.ToString("yyyyMMdd"), signal.Type, signal.WeekBaseCount, trade.ResultPercent);
                    tdis.Add(tdi);
                }
            }

            return tdis;
        }

        private List<Signal> ReadSignals(string path)
        {
            var signals = new List<Signal>();
            var lines = File.ReadAllLines(path);
            for (var i = 1; i < lines.Length; i += 1)
            {
                var rawSignal = lines[i].Split(',');
                var signal = new Signal(rawSignal[0], Convert.ToDateTime(rawSignal[1]), rawSignal[5], Convert.ToInt32(rawSignal[6]));
                signals.Add(signal);
            }

            return signals;
        }

        private List<Trade> ReadTrades(string path)
        {
            var trades = new List<Trade>();
            var lines = File.ReadAllLines(path);

            for (var i = 1; i < lines.Length; i += 1)
            {
                var rawTrade = lines[i].Replace("\"", "").Split(',');
                var trade = new Trade(rawTrade[2], Convert.ToDateTime(rawTrade[10]).Date, Convert.ToDouble(rawTrade[25]));

                trades.Add(trade);
            }

            return trades;
        }

        private void btnOpenOutputDir_Click(object sender, EventArgs e)
        {
            using (var openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    tbOutputDir.Text = openFolderDialog.SelectedPath;
                }
            }
        }
    }
}
