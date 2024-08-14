using System;
using System.Windows.Forms;


namespace ChartFileBuilder
{
    public partial class ChartFileBuilder : Form
    {

        private string _setupFileNameTemplate;
        private string _breakoutFileNameTemplate;
        private string _resultFileNameTemplate;

        private const string _symbolPlaceHolder = "symbol";
        private const string _datePlaceHolder = "date";
        private const string _baseCountPlaceHolder = "baseCount";
        private const string _setupClosePercentGainPlaceHolder = "setupClosePercentGain";
        private const string _breakoutClosePercentGainPlaceHolder = "_breakoutClosePercentGain";
        private const string _setupType = "_setupType";

        public ChartFileBuilder()
        {
            _setupFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_0_Setup_BCW{_baseCountPlaceHolder}_{_setupType}.JPG";
            _breakoutFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_1_Breakout_{_setupType}.JPG";
            _resultFileNameTemplate = $"{_datePlaceHolder}_{_symbolPlaceHolder}_2_Result_SU{_setupClosePercentGainPlaceHolder}_BO{_breakoutClosePercentGainPlaceHolder}_{_setupType}.JPG";

            InitializeComponent();
        }

        private void cmdGenerateFiles_Click(object sender, EventArgs e)
        {
            var sfn = _setupFileNameTemplate.Replace(_datePlaceHolder, tbDate.Text);
            sfn = sfn.Replace(_symbolPlaceHolder, tbSymbol.Text);
            sfn = sfn.Replace(_baseCountPlaceHolder, tbWeekBaseCount.Text);
            sfn = sfn.Replace(_setupType, cbSetupType.Text);

            var bofn = _breakoutFileNameTemplate.Replace(_datePlaceHolder, tbDate.Text);
            bofn = bofn.Replace(_symbolPlaceHolder, tbSymbol.Text);
            bofn = bofn.Replace(_setupType, cbSetupType.Text);

            var swingHigh = Convert.ToDouble(tbSwingHigh.Text);
            var suClose = Convert.ToDouble(tbSuClose.Text);
            var boClose = Convert.ToDouble(tbBoClose.Text);


            var suPercentGain = Math.Round((swingHigh - suClose) / suClose * 100, 0);
            var boPercentGain = Math.Round((swingHigh - boClose) / boClose * 100, 0);


            var rfn = _resultFileNameTemplate.Replace(_datePlaceHolder, tbDate.Text);
            rfn = rfn.Replace(_symbolPlaceHolder, tbSymbol.Text);
            rfn = rfn.Replace(_setupClosePercentGainPlaceHolder, suPercentGain.ToString());
            rfn = rfn.Replace(_breakoutClosePercentGainPlaceHolder, boPercentGain.ToString());
            rfn = rfn.Replace(_setupType, cbSetupType.Text);

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
    }
}
