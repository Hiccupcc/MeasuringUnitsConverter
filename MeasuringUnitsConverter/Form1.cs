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
            if (UserInput < 0 || UserInput == 0)
            {
                MessageBox.Show(NegNum);
            }



            // Calculations
            if (combo_input.Text == "Meter" && combo_output.Text == "Centimeter")
            {
                Answer = Convert.ToString(UserInput * 100);
                lbl_Convert.Text = Answer;
            }


            if (combo_input.Text == "Centimeter" && combo_output.Text == "Meter")
            {
                Answer = Convert.ToString(UserInput / 100);
                lbl_Convert.Text = Answer;
            }
            else

            if (combo_input.Text == "Kilogram" && combo_output.Text == "Gram")
            {
                Answer = Convert.ToString(UserInput * 1000);
                lbl_Convert.Text = Answer;
            }
            if (combo_input.Text == "Gram" && combo_output.Text == "Kilogram")
            {
                Answer = Convert.ToString(UserInput / 1000);
                lbl_Convert.Text = Answer;
            }


        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            string Zero = "0";
            if (txt_input.Text.Length == 0)
            {
                txt_input.Text = Zero;
            }
        }

        private void combo_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Zero = "0";
            txt_input.Text = Zero;
            lbl_Convert.Text = "";
            combo_input.Text = "";
            combo_output.Text = "";
        }
    }

}