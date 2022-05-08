namespace MeasuringUnitsConverter
{
    public partial class SimpleUnitsConverter : Form
    {
        public SimpleUnitsConverter()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            //variables
            double UserInput = Convert.ToDouble(txt_input.Text);
            string Answer = "";
            string NegNum = "Cannot Convert Numbers Equal to or Less than 0 ";
            // Error when trying to calculate a number that's = 0
            if (UserInput < 0 || UserInput == 0)
            {
                MessageBox.Show(NegNum);
            }
            // Calculations
            if (combo_input.Text == "Meter")
            {
                combo_output.Items.Clear();
                combo_output.Items.Add("Centimeter");
                Answer = Convert.ToString(UserInput * 100);
                txt_output.Text = Answer;
            }
            if (combo_input.Text == "Centimeter" && combo_output.Text == "Meter")
            {
                Answer = Convert.ToString(UserInput / 100);
                txt_output.Text = Answer;
            }
            if (combo_input.Text == "Kilogram" && combo_output.Text == "Gram")
            {
                Answer = Convert.ToString(UserInput * 1000);
                txt_output.Text = Answer;
            }
            if (combo_input.Text == "Gram" && combo_output.Text == "Kilogram")
            {
                Answer = Convert.ToString(UserInput / 1000);
                txt_output.Text = Answer;
            }
           


        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            //Makes textbox = 0 when empty to avoid crashes
            string Zero = "0";
            if (txt_input.Text.Length == 0)
            {
                txt_input.Text = Zero;
            }
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            //resets
            string Zero = "0";
            txt_input.Text = Zero;
            lbl_Convert.Text = "";
            combo_input.Text = "";
            combo_output.Text = "";
        }



        private void combo_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_input.Text == "Meter")
            {
                combo_output.Items.Clear();
                combo_output.Items.Add("Centimeter");
                combo_output.Text = "";
            }
            if (combo_input.Text == "Centimeter")
            {
                combo_output.Items.Clear();
                combo_output.Items.Add("Meter");
                combo_output.Text = "";
            }
            if (combo_input.Text == "Kilogram")
            {
                combo_output.Items.Clear();
                combo_output.Items.Add("Gram");
                combo_output.Text = "";
            }
            if (combo_input.Text == "Gram")
            {
                combo_output.Items.Clear();
                combo_output.Items.Add("Kilogram");
                combo_output.Text = "";
            }
           
        }
    }
}

