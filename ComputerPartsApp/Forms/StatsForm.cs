using System;
using System.Windows.Forms;
using ComputerPartsLibrary;

namespace ComputerPartsApp
{
    public partial class StatsForm : Form
    {
        internal Computer CurrentComputer { get; set; }

        public StatsForm(Computer currentComputer)
        {
            InitializeComponent();
            CurrentComputer = currentComputer;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            InitializeFields();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (CurrentComputer.Count != 0) InitializeFields();
            else MessageBox.Show("Моля, изберете поне една част!", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitializeFields()
        {
            lblIDval.Text = CurrentComputer.ID.ToString();
            lblNumOFPartsVal.Text = CurrentComputer.Count.ToString();
            lblTotalPriceVal.Text = CurrentComputer.Price.ToString("C");
            lblAvgVal.Text = Mathematics.GetAveragePrice(CurrentComputer).ToString("C");
            lblMedianVal.Text = Mathematics.CalculateMedian(CurrentComputer).ToString("C");
            comboBoxTime.Items.Clear();
            comboBoxInterest.Items.Clear();
            comboBoxTime.Items.AddRange(Mathematics.lisingMonths);
            comboBoxInterest.Items.AddRange(Mathematics.interestPercentages);

            var cheapestPart = Mathematics.GetCheapestPart(CurrentComputer);
            var expPart = Mathematics.GetMostExpensivePart(CurrentComputer);

            lblTotalValue.Visible = false;
            lblMonthlyValue.Visible = false;

            lblCheapestVal.Text = $"{cheapestPart.GetType().Name}: {cheapestPart.Price:C}";
            lblExpVal.Text = $"{expPart.GetType().Name}: {expPart.Price:C}";
        }

        public void StatsFormSetCurrentComputer(Computer pc) => CurrentComputer = pc;

        // Computes leasing info
        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem == null || comboBoxInterest.SelectedItem == null) MessageBox.Show("Моля изберете период и лихвен процент.", "Невалидни данни", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var totalResult = Mathematics.CalculateSimpleInterest(CurrentComputer.Price, int.Parse((comboBoxInterest.SelectedItem as string).TrimEnd('%')), int.Parse(comboBoxTime.SelectedItem as string));
                lblTotalValue.Text = totalResult.ToString("C");
                lblMonthlyValue.Text = (totalResult / int.Parse(comboBoxTime.SelectedItem as string)).ToString("C");
                lblTotalValue.Visible = true;
                lblMonthlyValue.Visible = true;
            }
        }
    }
}
