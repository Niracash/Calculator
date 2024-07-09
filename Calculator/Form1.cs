using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string calculation = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            calculation += (sender as Button).Text;
            caLcOutput.Text = calculation;
        }
        private void answer_button(object sender, EventArgs e)
        {
            string formatCalc = calculation.ToString();
            try
            {
                caLcOutput.Text = new DataTable().Compute(formatCalc, null).ToString();
                calculation = caLcOutput.Text;
            }
            catch (Exception)
            {
                caLcOutput.Text = "Math is not mathing :(";
                calculation = "";
            }
        }
        private void clear_button(object sender, EventArgs e)
        {
            caLcOutput.Text = "";
            calculation = "";
        }

        private void del_button(object sender, EventArgs e)
        {
            if (calculation.Length > 0) {
                calculation = calculation.Remove(calculation.Length - 1, 1);
            }
            caLcOutput.Text=calculation;
        }
    }
}
