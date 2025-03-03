namespace BMIDB
{
    public partial class EnhancedBMI : Form
    {
        public EnhancedBMI()
        {
            InitializeComponent();
        }

        private void lblAdultBMICalculator_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double.TryParse(txtHeight.Text, out double height);//if 0 failed
            double.TryParse(txtWeight.Text, out double weight);

            double G = 1;

            string gender = "";

            if (lbxGender.SelectedItem == "Male")
            {
                gender = "Male";
                G = 1.6;
            }else if (lbxGender.SelectedItem == "Female")
            {
                gender = "Female";
                G = 1.4;
            }

            // if any of the three have an error, calculation can't occur
            if (height != 0 & weight != 0 & gender.Length > 0)
            {
                //we can calculate normal BMI
                double BMI = weight / height / height * 240 * G;
                txtBMI.Text = (Math.Round(BMI, 2)).ToString();

            }else
            {
                MessageBox.Show("Please enter valid inputs and only select one gender. Try again.");
            }
        }

    }
}
