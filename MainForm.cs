namespace Assignment_3
{
    public partial class MainForm : Form
    {
        private string name = string.Empty;
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
            // Begin my work

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Change the name of the porogramm and makes all the labels empty. And writes out
            // Normal weight and Normal bmi. 
            this.Text += " Calculator";
            lblBMI.Text = string.Empty;
            lblBMI.Text = string.Empty;
            lblWeightCat.Text = string.Empty;
            lblNormalBMI.Text = "Normal Weight";
            rbtnMetric.Checked = true;
            lblNormalBMI.Text = "Normal BMI is between 18,50 and 24,9";
        }

        private void UppdateHeightText()
        {
            // Check if the metric or imperial button ish checked to show the right things
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInc.Visible = false;                
            }
            else
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
                txtInc.Visible = true;
            }
            lblWeightCat.Text = "";
            lblBMI.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        // uppdates the depending if the bmetric button is cheched
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UppdateHeightText();
        }

        // uppdated the values if imperail button is cecked
        private void rbtnimperial_CheckedChanged(object sender, EventArgs e)
        {
            UppdateHeightText();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // checks if the input the user wrote in the gui is correct
            bool ok = ReadInputBMI();

            // send the inputs to get calculated
            if (ok)
            {
                CalculateAndDisplayResults();

            }

            
        }
        // changes the bmi value to wrap upp the numbers
        private void CalculateAndDisplayResults()
        {
            double bmi = bmiCalc.CalculateBMI();
            lblBMI.Text = bmi.ToString("f2");
            lblWeightCat.Text = bmiCalc.BmiWeightCategory();
        }



        private bool ReadInputBMI()
        {
            ReadName();
            bool heightok = ReadHeight();
            bool weightok = ReadWeight();
            ReadUnit();

            return heightok && weightok;
        }

        private void ReadUnit()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnit(UnitTypes.Metric);
            else
                bmiCalc.SetUnit(UnitTypes.Imperial);
        }


        // reads the name from the txtname and putts the name into the grpResults box
        private void ReadName()
        {
            name = txtName.Text.Trim();
            name = name.Trim();
            grpResults.Text = name;
        }

        // reads the height from the gui and checks so it
        // is in the right format so you have not written letters
        private bool ReadHeight()
        {
            double height = 0.0;

            bool ok = double.TryParse(txtCmFt.Text, out height);

            if (!ok) 
            {
                MessageBox.Show("The height value is invalid", "Error");
            }

            double inch = 0.0;
            if (rbtnimperial.Checked)
            {
                ok = ok && double.TryParse(txtInc.Text, out inch);
                if (!ok) 
                {
                    MessageBox.Show("The inch value is invalid", "Error");
                }
            }

            
            if (bmiCalc.GetUnit() == UnitTypes.Metric)
                height = height / 100.0; // cm to meter
            else
                height = height * 12.0 + inch; // ft to inch

            bmiCalc.SetHeight(height);

            return ok;
        }

        // reads the weight value from the gui and check if its valid
        private bool ReadWeight()
        {
            double weight = 0.0;
            bool ok = double.TryParse(txtWeight.Text, out weight);
            if (!ok) 
            {
                MessageBox.Show("The Weight value is invalid", "Error");
            }
            bmiCalc.SetWeight(weight);
            return ok;
        }

        // simple command to center the gui screen in the center of your screen
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
